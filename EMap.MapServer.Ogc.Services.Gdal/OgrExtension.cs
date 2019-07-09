using OSGeo.OGR;
using EMap.MapServer.Ogc.Ows1_1;
using EMap.MapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EMap.MapServer.Ogc.Services.Gdals
{
    public static class OgrExtension
    {
        public static void GetExtent(this Layer layer, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            using (Envelope envelope = new Envelope())
            {
                var ret = layer.GetExtent(envelope, 1);
                xMin = envelope.MinX;
                yMin = envelope.MinY;
                xMax = envelope.MaxX;
                yMax = envelope.MaxY;
            }
        }
        public static LayerType AddToCapabilities(this DataSource dataSource,string name, Capabilities capabilities)
        {
            string projectionStr;
            double xMin, yMin, xMax, yMax;
            using (var layer = dataSource.GetLayerByIndex(0))
            {
                using (var sr = layer.GetSpatialRef())
                {
                    var ret = sr.ExportToWkt(out projectionStr);
                }
                layer.GetExtent(out xMin, out yMin, out xMax, out yMax);
            }
            LayerType layerType = CapabilitiesHelper.AddToCapabilities(capabilities, name, projectionStr, xMin, yMin, xMax, yMax);
            return layerType;
        }
    }
}
