using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public abstract class ServiceFasctory : IServiceFasctory
    {
        public virtual IService GetService()
        {
            throw new NotImplementedException();
        }
    }
}
