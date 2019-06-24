using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMapServer.Ogc.Services
{
    public interface IWmtsServiceFasctory : IOgcServiceFasctory
    {
        new IWmtsService GetService();
    }
}
