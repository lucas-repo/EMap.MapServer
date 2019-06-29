using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public abstract class OgcServiceFasctory : ServiceFasctory, IOgcServiceFasctory
    {
        public new virtual IOgcService GetService()
        {
            throw new NotImplementedException();
        }
    }
}
