using EMap.MapServer.Ogc.Services;
using EMap.MapServer.Ogc.Services.Gdals;
using EMap.MapServer.Services.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OSGeo.GDAL;
using System;

namespace EMap.MapServer.Services.Controllers
{
    public abstract class BaseApiController : ControllerBase, IDisposable
    {
        protected IHostingEnvironment HostingEnvironment { get; }
        protected ConfigContext ConfigContext { get;  set; }
        protected ServicePathManager ServiceManager { get; }
        public BaseApiController(IHostingEnvironment environment, ConfigContext configContext)
        {
            
            HostingEnvironment = environment;
            ConfigContext = configContext;
            ServiceManager = new ServicePathManager(HostingEnvironment.WebRootPath, ConfigContext);
        }
        public virtual void Dispose()
        {
            if (ConfigContext != null)
            {
                ConfigContext.Dispose();
                ConfigContext = null;
            }
        }
    }
}