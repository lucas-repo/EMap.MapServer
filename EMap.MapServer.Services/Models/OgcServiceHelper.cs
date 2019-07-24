//using EMap.MapServer.DotSpatial;
using EMap.MapServer.Ogc.Services;
using EMap.MapServer.Ogc.Services.Gdals;
using EMap.MapServer.Ogc.Wmts1;
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
        public static string GetRoutTemplate<T>(string methodName=null) where T : ControllerBase
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
        public bool AddLayerToCapabilities(OgcServiceType serviceType, string serviceVersion, string capabilitiesPath, string layerPath)
        {
            bool ret = false;
            IOgcService ogcService = GetOgcService(serviceType, serviceVersion);
            switch (serviceType)
            {
                case OgcServiceType.Wmts:
                    IWmtsService wmtsService = ogcService as IWmtsService;
                    Capabilities capabilities = null;
                    using (StreamReader sr = new StreamReader(capabilitiesPath))
                    {
                        capabilities = wmtsService.XmlDeSerialize(sr);
                    }
                    if (capabilities != null)
                    {
                        LayerType layerType = wmtsService.AddContent(capabilities, layerPath);
                        if (layerType != null)
                        {
                            using (StreamWriter sw = new StreamWriter(capabilitiesPath))
                            {
                                wmtsService.XmlSerialize(sw, capabilities);
                            }
                            ret = true;
                        }
                    }
                    break;
            }
            return ret;
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
        /// 将文件移动至新的位置，将会移动所有相同名称不同后缀的文件
        /// </summary>
        /// <param name="srcFileName"></param>
        /// <param name="destFileName"></param>
        public static void MoveFile(string srcFileName, string destFileName)
        {
            if (File.Exists(srcFileName))
            {
                string srcDirectory = Path.GetDirectoryName(srcFileName);
                string srcName = Path.GetFileNameWithoutExtension(srcFileName);
                string[] srcFileNames = Directory.GetFiles(srcDirectory, $"{srcName}.*");
                string destDirectory = Path.GetDirectoryName(destFileName);
                if (!Directory.Exists(destDirectory))
                {
                    Directory.CreateDirectory(destDirectory);
                }
                foreach (var srcPath in srcFileNames)
                {
                    string nameWithExtension = Path.GetFileName(srcPath);
                    string destPath = Path.Combine(destDirectory, nameWithExtension);
                    File.Move(srcPath, destPath);
                }
            }
        }
    }
}
