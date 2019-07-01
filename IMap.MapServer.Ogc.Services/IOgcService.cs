using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Services
{
    public interface IOgcService:IService
    {
        string Service { get; }
        string Version { get; }
    }
}
