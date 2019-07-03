using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Services
{
    public interface IWfsServiceFasctory2 : IOgcServiceFasctory
    {
        new IWfsService2 GetService();
    }
}
