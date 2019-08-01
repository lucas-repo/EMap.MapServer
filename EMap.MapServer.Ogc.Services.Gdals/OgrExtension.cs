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
        public static LayerType AddToCapabilities(this DataSource dataSource, string name, Capabilities capabilities)
        {
            string projectionStr;
            double xMin, yMin, xMax, yMax;
            string tileMatrixSet = null;
            using (var layer = dataSource.GetLayerByIndex(0))
            {
                string layerName = layer.GetName();//todo 调试是否乱码
                using (var spatialReference = layer.GetSpatialRef())
                {
                    tileMatrixSet = spatialReference.GetAttrValue("GEOGCS", 0);
                    var ret = spatialReference.ExportToWkt(out projectionStr);
                }
                layer.GetExtent(out xMin, out yMin, out xMax, out yMax);
            }
            int minZoom = 0;
            int maxZoom = 19;
            dataSource.GetSuitableZoom(ref minZoom, ref maxZoom);
            LayerType layerType = CapabilitiesHelper.AddToCapabilities(capabilities, name, projectionStr, xMin, yMin, xMax, yMax, minZoom, maxZoom);
            string href = capabilities.GetHref(WmtsOperationType.GetTile, WmtsRequestType.REST);
            URLTemplateType tileTemplate = CapabilitiesHelper.CreateTileResourceURL(href, name, tileMatrixSet);
            URLTemplateType featureInfoTemplate = CapabilitiesHelper.CreateFeatureInfoResourceURL(href, name, tileMatrixSet);
            layerType.ResourceURL = new URLTemplateType[] { tileTemplate, featureInfoTemplate };
            return layerType;
        }
        public static void GetSuitableZoom(this DataSource dataSource, ref int minZoom, ref int maxZoom)
        {
            string projcs = null;
            string geogcs = null;
            double xMin, yMin, xMax, yMax;
            using (var layer = dataSource.GetLayerByIndex(0))
            {
                string layerName = layer.GetName();//todo 调试是否乱码
                using (var spatialReference = layer.GetSpatialRef())
                {
                    projcs = spatialReference.GetAttrValue("PROJCS", 0);
                    if (string.IsNullOrEmpty(projcs))
                    {
                        geogcs = spatialReference.GetAttrValue("GEOGCS", 0);
                    }
                }
                layer.GetExtent(out xMin, out yMin, out xMax, out yMax);
            }
            double dWidth = Math.Max(xMax - xMin, yMax - yMin);
            bool isDegree = projcs == null && geogcs != null;
            for (int i = 0; i < 30; i++)
            {
                double tmpResolution = TileMatrix.GetResolution(isDegree, i);
                if (dWidth / tmpResolution > 256)
                {
                    if (i == 0)
                    {
                        minZoom = i;
                    }
                    else
                    {
                        minZoom = i - 1;
                    }
                    break;
                }
            }
            maxZoom = 19;
        }
    }
}
