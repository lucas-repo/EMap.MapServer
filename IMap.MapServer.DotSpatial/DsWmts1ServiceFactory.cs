using IMap.MapServer.Ogc.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMap.MapServer.DotSpatial
{
    public class DsWmts1ServiceFactory : WmtsServiceFasctory, IDsWmts1ServiceFactory
    {
        public new virtual IDsWmts1Service GetService()
        {
            return new DsWmts1Service();
        }
    }
}
