//using EMap.MapServer.DotSpatial;
using EMap.MapServer.Ogc.Services;
using EMap.MapServer.Ogc.Services.Gdals;
using EMap.MapServer.Ogc.Wmts1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public class OgcServiceHelper
    {
        ConfigContext _configContext;
        ServicePathManager _servicePathManager;
        string _host;
        public OgcServiceHelper(ConfigContext configContext, ServicePathManager servicePathManager, string host)
        {
            _configContext = configContext;
            _servicePathManager = servicePathManager;
            _host = host;
        }
        public async Task<bool> CreateCapabilities(OgcServiceType serviceType, string serviceVersion, string serviceName)
        {
            bool ret = false;
            if (_configContext == null || _servicePathManager == null  || string.IsNullOrEmpty(serviceVersion) || string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(_host))
            {
                Debug.WriteLine("参数不能为空");
                return ret;
            }
            ServiceRecord serviceRecord = await _configContext.Services.FirstOrDefaultAsync(x => x.Type == serviceType && x.Version == serviceVersion && x.Name == serviceName);
            if (serviceRecord != null)
            {
                return ret;
            }
            string serviceDirectory = _servicePathManager.GetServiceDirectory(serviceType, serviceVersion, serviceName);
            if (!Directory.Exists(serviceDirectory))
            {
                Directory.CreateDirectory(serviceDirectory);
            }
            string servicePath = null;
            IOgcService ogcService = GetOgcService(serviceType, serviceVersion);
            if (ogcService is IWmtsService wmtsService)
            {
                string href = $"{_host}/EMap/Services/{serviceName}/MapServer/Wmts";
                Capabilities capabilities = wmtsService.CreateCapabilities(href);
                servicePath = Path.Combine(serviceDirectory, "WMTSCapabilities.xml");
                using (StreamWriter sw = new StreamWriter(servicePath))
                {
                    wmtsService.XmlSerialize(sw, capabilities);
                }
            }
            else
            {
                return ret;
            }
            serviceRecord = new ServiceRecord()
            {
                Name = serviceName,
                Path = servicePath,
                Type = serviceType,
                Version = serviceVersion
            };
            _configContext.Services.Add(serviceRecord);
            var result = await _configContext.SaveChangesAsync();
            ret = true;
            return ret;
        }
        public static IOgcService GetOgcService(OgcServiceType serviceType, string serviceVersion)
        {
            IOgcService ogcService = null;
            if ( string.IsNullOrWhiteSpace(serviceVersion))
            {
                return ogcService;
            }
            switch (serviceType)
            {
                case  OgcServiceType.Wfs:
                    switch (serviceVersion)
                    {
                        case "2.0.0":
                            //serviceFasctory = new DsWfs2ServiceFactory();
                            break;
                    }
                    break;
                case OgcServiceType.Wcs:
                    switch (serviceVersion)
                    {
                        case "2.0.0":
                            //serviceFasctory = new DsWfs2ServiceFactory();
                            break;
                    }
                    break;
                case OgcServiceType.Wmts:
                    switch (serviceVersion)
                    {
                        case "1.0.0":
                            //DsWmts1ServiceFactory dsWmts1ServiceFactory = new DsWmts1ServiceFactory();
                            ogcService = new GdalWmtsService();
                            break;
                    }
                    break;
                case OgcServiceType.Wms:
                    switch (serviceVersion)
                    {
                        case "2.0.0":
                            //serviceFasctory = new DsWfs2ServiceFactory();
                            break;
                    }
                    break;
            }
            return ogcService;
        }
    }
}
