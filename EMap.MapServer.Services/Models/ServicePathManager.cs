using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public class ServicePathManager
    {
        public string RootPath { get; }
        public ConfigContext ConfigContext { get; }
        public ServicePathManager(string rootPath, ConfigContext configContext)
        {
            RootPath = rootPath;
            ConfigContext = configContext;
        }
        public string GetServicesDirectory()
        {
            return Path.Combine(RootPath, "Services");
        }
        public string GetTempDirectory()
        {
            return Path.Combine(RootPath, "Temp");
        }
        public string GetServiceTypeDirectory(OgcServiceType serviceType)
        {
            string directory = GetServicesDirectory();
            return Path.Combine(directory, serviceType.ToString());
        }
        public string GetServiceVersionDirectory(OgcServiceType serviceType, string serviceVersion)
        {
            string directory = GetServiceTypeDirectory(serviceType);
            return Path.Combine(directory, serviceVersion);
        }
        public string GetServiceDirectory(OgcServiceType serviceType, string serviceVersion, string serviceName)
        {
            string directory = GetServiceVersionDirectory(serviceType, serviceVersion);
            return Path.Combine(directory, serviceName);
        }

        public string GetCapabilitiesPath(OgcServiceType serviceType, string serviceVersion, string serviceName)
        {
            string directory = GetServiceDirectory(serviceType, serviceVersion, serviceName);
            string name = null;
            switch (serviceType)
            {
                case OgcServiceType.Wmts:
                    name = "WMTSCapabilities.xml";
                    break;
            }
            string path = null;
            if (!string.IsNullOrEmpty(name))
            {
                path = Path.Combine(directory, name);
            }
            return path;
        }
    }
}
