using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public interface IWmtsServiceFasctory : IOgcServiceFasctory
    {
        new IWmtsService GetService();
    }
}
