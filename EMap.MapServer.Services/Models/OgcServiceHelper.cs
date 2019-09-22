//using EMap.MapServer.DotSpatial;
using EMap.OgcStandards.Services;
using EMap.OgcStandards.Services.Gdals;
using EMap.OgcStandards.Wmts1;
using EMap.MapServer.Services.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSGeo.GDAL;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private static string GetTemplate(object[] attributes)
        {
            string template = null;
            if (attributes.Length > 0 && attributes[0] is RouteAttribute routeAttribute)
            {
                template = routeAttribute.Template;
            }
            return template;
        }
        public static string GetRoutTemplate<T>(string methodName = null) where T : ControllerBase
        {
            Type type = typeof(T);
            object[] classAttributes = type.GetCustomAttributes(typeof(RouteAttribute), false);
            string routTemplate = GetTemplate(classAttributes);
            if (methodName != null)
            {
                var methodInfo = type.GetMethod(methodName);
                object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(RouteAttribute), false);
                string methodRoutTemplate = GetTemplate(methodAttributes);
                if (string.IsNullOrEmpty(routTemplate))
                {
                    routTemplate = methodRoutTemplate;
                }
                else
                {
                    if (!string.IsNullOrEmpty(methodRoutTemplate))
                    {
                        routTemplate = $"{routTemplate}/{methodRoutTemplate}";
                    }
                }
            }
            return routTemplate;
        }
        public async Task<bool> CreateCapabilities(OgcServiceType serviceType, string serviceVersion, string serviceName)
        {
            bool ret = false;
            if (_configContext == null || _servicePathManager == null || string.IsNullOrEmpty(serviceVersion) || string.IsNullOrEmpty(serviceName) || string.IsNullOrEmpty(_host))
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
                string routTemplate = GetRoutTemplate<WmtsController>();
                routTemplate = routTemplate.Replace("{serviceName}", serviceName);
                string href = $"{_host}/{routTemplate}";
                //string href = $"{_host}/EMap/Services/{serviceName}/MapServer/Wmts";
                Capabilities capabilities = wmtsService.CreateCapabilities(href);
                servicePath = Path.Combine(serviceDirectory, "WMTSCapabilities.xml");
                SaveCapabilities(wmtsService, servicePath, capabilities);
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
        public bool AddLayerToCapabilities(ServiceRecord serviceRecord, string capabilitiesPath, string layerPath)
        {
            bool ret = false;
            IOgcService ogcService = GetOgcService(serviceRecord.Type, serviceRecord.Version);
            switch (serviceRecord.Type)
            {
                case OgcServiceType.Wmts:
                    IWmtsService wmtsService = ogcService as IWmtsService;
                    Capabilities capabilities = GetCapabilities(wmtsService, capabilitiesPath);
                    if (capabilities != null)
                    {
                        LayerType layerType = wmtsService.AddLayerType(capabilities, layerPath);
                        if (layerType != null)
                        {
                            SaveCapabilities(wmtsService, capabilitiesPath, capabilities);
                            ret = true;
                        }
                    }
                    break;
            }
            if (ret)
            {
                string destName = Path.GetFileNameWithoutExtension(layerPath);
                LayerRecord layerRecord = new LayerRecord()
                {
                    Name = destName,
                    Path = layerPath,
                    Service = serviceRecord
                };
                _configContext.Layers.Add(layerRecord);
            }
            return ret;
        }
        public static Capabilities GetCapabilities(IWmtsService wmtsService, string capabilitiesPath)
        {
            Capabilities capabilities = null;
            using (StreamReader sr = new StreamReader(capabilitiesPath))
            {
                capabilities = wmtsService.XmlDeSerialize(sr);
            }
            return capabilities;
        }
        public static void SaveCapabilities(IWmtsService wmtsService, string capabilitiesPath, Capabilities capabilities)
        {
            using (StreamWriter sw = new StreamWriter(capabilitiesPath))
            {
                wmtsService.XmlSerialize(sw, capabilities);
            }
        }
        public async Task RemoveLayerFromCapabilities(ServiceRecord serviceRecord, string capabilitiesPath, LayerRecord layerRecord)
        {
            if (layerRecord == null)
            {
                return;
            }
            #region 删除数据库及数据
            _configContext.Layers.Remove(layerRecord);
            var ret= await _configContext.SaveChangesAsync();
            DeleteDataSet(layerRecord.Path);
            #endregion
            #region 删除XML中的图层
            IOgcService ogcService = GetOgcService(serviceRecord.Type, serviceRecord.Version);
            switch (serviceRecord.Type)
            {
                case OgcServiceType.Wmts:
                    IWmtsService wmtsService = ogcService as IWmtsService;
                    Capabilities capabilities = GetCapabilities(wmtsService, capabilitiesPath);
                    wmtsService.RemoveLayerType(capabilities, layerRecord.Name);
                    SaveCapabilities(wmtsService, capabilitiesPath, capabilities);
                    break;
            }
            #endregion
        }
        public static IOgcService GetOgcService(OgcServiceType serviceType, string serviceVersion)
        {
            IOgcService ogcService = null;
            if (string.IsNullOrWhiteSpace(serviceVersion))
            {
                return ogcService;
            }
            switch (serviceType)
            {
                case OgcServiceType.Wfs:
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
        /// <summary>
        /// 获取数据集（相同名称不同后缀）的所有文件全名
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string[] GetDataSetFileNames(string fileName)
        {
            string[] fileNames = null;
            if (File.Exists(fileName))
            {
                string srcDirectory = Path.GetDirectoryName(fileName);
                string srcName = Path.GetFileNameWithoutExtension(fileName);
                fileNames = Directory.GetFiles(srcDirectory, $"{srcName}.*");
            }
            return fileNames;
        }
        public static void DeleteDataSet(string fileName)
        {
            string[] fileNames = GetDataSetFileNames(fileName);
            if (fileNames != null)
            {
                foreach (var item in fileNames)
                {
                    if (File.Exists(item))
                    {
                        File.Delete(item);
                    }
                }
            }
        }
        /// <summary>
        /// 将数据集移动至新的位置，将会移动所有相同名称不同后缀的文件
        /// </summary>
        /// <param name="srcFileName"></param>
        /// <param name="destFileName"></param>
        public static void MoveDataSet(string srcFileName, string destFileName)
        {
            string[] srcFileNames = GetDataSetFileNames(srcFileName);
            if (srcFileNames != null)
            {
                string destDirectory = Path.GetDirectoryName(destFileName);
                if (!Directory.Exists(destDirectory))
                {
                    Directory.CreateDirectory(destDirectory);
                }
                foreach (var srcPath in srcFileNames)
                {
                    string nameWithExtension = Path.GetFileName(srcPath);
                    string destPath = Path.Combine(destDirectory, nameWithExtension);
                    if (File.Exists(destPath))
                    {
                        File.Delete(destPath);
                    }
                    File.Move(srcPath, destPath);
                }
            }
        }
    }
}
