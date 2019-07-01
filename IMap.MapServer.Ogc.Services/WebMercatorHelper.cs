using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.Ogc.Services
{ 
    public static class WebMercatorHelper
    {
        public const double Semimajor = 6378137.0;
        public const double Semiminor = 6356752.314245179;

        public static void LonLat2WebMercator(double longitude, double latitude,out double x,out double y)
        {
            double halfPerimeter = Math.PI * Semimajor;
            x = longitude * halfPerimeter / 180;
            y = Math.Log(Math.Tan((90 + latitude) * Math.PI / 360)) / (Math.PI / 180);
            y *= halfPerimeter/180;
        }
        public static void WebMercator2LonLat(double x, double y, out double longitude, out double latitude,double falseEasting =0,double falseNorthing=0)
        {
            double halfPerimeter = Math.PI * Semimajor;
            longitude = (x- falseEasting) / halfPerimeter * 180;
            latitude = (y-falseNorthing) / halfPerimeter * 180;
            latitude = 180 / Math.PI * (2 * Math.Atan(Math.Exp(latitude * Math.PI / 180)) - Math.PI / 2);
        }
    }
}
