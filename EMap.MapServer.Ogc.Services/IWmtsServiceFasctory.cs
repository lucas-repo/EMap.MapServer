using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Services
{
    public interface IWmtsServiceFasctory : IOgcServiceFasctory
    {
        new IWmtsService GetService();
    }
}
