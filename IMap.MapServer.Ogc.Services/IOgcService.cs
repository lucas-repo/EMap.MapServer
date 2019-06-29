using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.Ogc.Services
{
    public interface IOgcService:IService
    {
        string Service { get; }
        string Version { get; }
    }
}
