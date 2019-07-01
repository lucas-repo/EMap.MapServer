using Microsoft.AspNetCore.Mvc;
using System;

namespace EMap.MapServer.Services.Controllers
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