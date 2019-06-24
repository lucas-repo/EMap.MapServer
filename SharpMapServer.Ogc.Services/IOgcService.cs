using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMapServer.Ogc.Services
{
    public interface IOgcService:IService
    {
        string Service { get; }
        string Version { get; }
    }
}
