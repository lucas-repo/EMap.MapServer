using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public interface IOgcServiceFasctory: IServiceFasctory
    {
        new IOgcService GetService();
    }
}
