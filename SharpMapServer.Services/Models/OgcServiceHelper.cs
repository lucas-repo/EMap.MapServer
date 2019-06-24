using SharpMapServer.DotSpatial;
using SharpMapServer.Ogc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpMapServer.Services.Models
{
    public static class OgcServiceHelper
    {
        public static IOgcService GetOgcService(string serviceType, string version)
        {
            IOgcService ogcService = null;
            if (string.IsNullOrWhiteSpace(serviceType) || string.IsNullOrWhiteSpace(version))
            {
                return ogcService;
            }
            switch (serviceType.ToLower())
            {
                case "wfs":
                    switch (version)
                    {
                        case "2.0.0":
                            //serviceFasctory = new DsWfs2ServiceFactory();
                            break;
                    }
                    break;
                case "wcs":
                    switch (version)
                    {
                        case "2.0.0":
                            //serviceFasctory = new DsWfs2ServiceFactory();
                            break;
                    }
                    break;
                case "wmts":
                    switch (version)
                    {
                        case "1.0.0":
                            DsWmts1ServiceFactory dsWmts1ServiceFactory = new DsWmts1ServiceFactory();
                            ogcService = dsWmts1ServiceFactory?.GetService();
                            break;
                    }
                    break;
                case "wms":
                    switch (version)
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
