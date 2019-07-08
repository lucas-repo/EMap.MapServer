using OSGeo.GDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public static class GdalHelper
    {
        public static void GdalConfigure()
        {
            Gdal.AllRegister();
        }
    }
}
