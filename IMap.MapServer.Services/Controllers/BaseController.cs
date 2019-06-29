using Microsoft.AspNetCore.Mvc;
using System;

namespace IMap.MapServer.Services.Controllers
{
    public abstract class BaseController : ControllerBase, IDisposable
    {
       
        public virtual void Dispose()
        {
            //if (ConfigContext != null)
            //{
            //    ConfigContext.Dispose();
            //    ConfigContext = null;
            //}
        }
    }
}