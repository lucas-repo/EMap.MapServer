using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMap.MapServer.Services.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EMap.MapServer.Services.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IHostingEnvironment HostingEnvironment { get; }
        protected ConfigContext ConfigContext { get; set; }
        protected ServicePathManager ServicePathManager { get; }
        private OgcServiceHelper _ogcServiceHelper;
        protected OgcServiceHelper OgcServiceHelper
        {
            get
            {
                if (_ogcServiceHelper == null)
                {
                    string href = GetHref();
                    _ogcServiceHelper = new OgcServiceHelper(ConfigContext, ServicePathManager, href);
                }
                return _ogcServiceHelper;
            }
        }
        public BaseController(IHostingEnvironment environment, ConfigContext configContext)
        {
            HostingEnvironment = environment;
            ConfigContext = configContext;
            ServicePathManager = new ServicePathManager(HostingEnvironment.ContentRootPath, ConfigContext);
        }
        protected string GetHref()
        {
            string href = $"{Request.Scheme}://{Request.Host}";
            return href;
        }
    }
}