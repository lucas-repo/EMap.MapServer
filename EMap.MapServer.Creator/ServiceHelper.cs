using Microsoft.EntityFrameworkCore;
using EMap.MapServer.Ogc.Services;
using EMap.MapServer.Ogc.Wmts1;
using EMap.MapServer.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMap.MapServer.Creator
{
    public class ServiceHelper
    {
        private ConfigContext _configContext;
        public ServiceHelper(ConfigContext configContext)
        {
            _configContext = configContext;
        }
        public async Task<bool> ExistedService(string serviceName, string serviceType, string serviceVersion)
        {
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, serviceType, serviceVersion);
            bool ret = serviceRecord != null;
            return ret;
        }
        public async Task<ServiceRecord> GetServiceRecord(string serviceName, string serviceType, string serviceVersion)
        {
            ServiceRecord serviceRecord = await _configContext.Services.FirstOrDefaultAsync(x => x.Type == serviceType && x.Version == serviceVersion && x.Name == serviceName);
            return serviceRecord;
        }
        private async Task<bool> AddServiceRecord(string serviceName, string serviceType, string serviceVersion, string capabilitiesPath)
        {
            ServiceRecord serviceRecord = new ServiceRecord()
            {
                Name = serviceName,
                Type = serviceType,
                Version = serviceVersion,
                Path = capabilitiesPath
            };
            await _configContext.Services.AddAsync(serviceRecord);
            int result = await _configContext.SaveChangesAsync();
            bool ret = result > 0;
            return ret;
        }
        private async Task<bool> AddLayerRecord(ServiceRecord serviceRecord, string layerName, string layerPath)
        {
            LayerRecord layerRecord = new LayerRecord()
            {
                Name = layerName,
                Service = serviceRecord,
                Path = layerPath
            };
            await _configContext.Layers.AddAsync(layerRecord);
            int result = await _configContext.SaveChangesAsync();
            bool ret = result > 0;
            return ret;
        }
        public async Task<bool> CreateService(string serviceName, string serviceType, string version, IEnumerable<string> files)
        {
            bool ret = false;
            string url = null;
            if (string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(serviceType) || string.IsNullOrEmpty(version) || files == null || files.Count() == 0)
            {
                return ret;
            }
            bool isExisted = await ExistedService(serviceName, serviceType, version);
            if (isExisted)
            {
                return ret;
            }
            string href = JsonSettings.DefaultSettings.GetValue<string>("href");
            string capabilitiesPath = null;
            IOgcService ogcService = OgcServiceHelper.GetOgcService(serviceType, version);
            Dictionary<string, string> layerNameAndPathes = new Dictionary<string, string>();
            if (ogcService is IWmtsService wmts1Service)
            {
                href = $"{href}/EMap.MapServer/Services/{serviceName}/MapServer/Wmts";
                Capabilities capabilities = wmts1Service.CreateCapabilities(href);
                string directory = null;
                foreach (var file in files)
                {
                    if (directory == null)
                    {
                        directory = Path.GetDirectoryName(file);
                    }
                    LayerType layerType = wmts1Service.AddContent(capabilities, file);
                    string name = Path.GetFileNameWithoutExtension(file);
                    layerNameAndPathes[name] = file;
                }
                capabilitiesPath = Path.Combine(directory, "WMTSCapabilities.xml");
                using (StreamWriter sw = new StreamWriter(capabilitiesPath))
                {
                    wmts1Service.XmlSerialize(sw, capabilities);
                }
                url = $"{href}/1.0.0/WMTSCapabilities.xml";
            }
            else
            {
                return ret;
            }
            ret = await AddServiceRecord(serviceName, serviceType, version, capabilitiesPath);
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, serviceType, version);
            foreach (var item in layerNameAndPathes)
            {
                bool result = await AddLayerRecord(serviceRecord, item.Key, item.Value);
            }
            if (!ret)
            {
                File.Delete(capabilitiesPath);
            }
            return ret;
        }
    }
}
