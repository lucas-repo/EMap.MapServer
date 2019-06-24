﻿using SharpMapServer.Ogc.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMapServer.DotSpatial
{
    public class DsWmts1ServiceFactory : WmtsServiceFasctory, IDsWmts1ServiceFactory
    {
        public new virtual IDsWmts1Service GetService()
        {
            return new DsWmts1Service();
        }
    }
}
