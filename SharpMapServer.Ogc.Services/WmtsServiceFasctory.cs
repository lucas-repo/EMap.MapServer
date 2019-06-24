using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMapServer.Ogc.Services
{
    public abstract class WmtsServiceFasctory : OgcServiceFasctory, IWmtsServiceFasctory
    {
        public new virtual IWmtsService GetService()
        {
            return GetService() as IWmtsService;
        }
    }
}
