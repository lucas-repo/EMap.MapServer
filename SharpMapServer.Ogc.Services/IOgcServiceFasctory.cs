using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMapServer.Ogc.Services
{
    public interface IOgcServiceFasctory: IServiceFasctory
    {
        new IOgcService GetService();
    }
}
