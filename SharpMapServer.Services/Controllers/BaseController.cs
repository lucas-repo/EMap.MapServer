using Microsoft.AspNetCore.Mvc;
using System;

namespace SharpMapServer.Services.Controllers
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