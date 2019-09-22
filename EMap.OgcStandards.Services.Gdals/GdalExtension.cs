using OSGeo.GDAL;
using EMap.OgcStandards.Ows1_1;
using EMap.OgcStandards.Wmts1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EMap.OgcStandards.Services.Gdals
{
    public static class GdalExtension
    {
        public static void GetWorldCoord(double[] affineCoefficients, int col, int row, out double x, out double y)
        {
            if (affineCoefficients?.Length != 6)
            {
                throw new Exception("argout参数不正确");
            }
            x = affineCoefficients[0] + affineCoefficients[1] * col + affineCoefficients[2] * row;
            y = affineCoefficients[3] + affineCoefficients[4] * col + affineCoefficients[5] * row;
        }
        public static void GetExtent(this Dataset dataset, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            double[] affineCoefficients = new double[6];
            dataset.GetGeoTransform(affineCoefficients);
            GetWorldCoord(affineCoefficients, 0, dataset.RasterYSize, out xMin, out yMin);
            GetWorldCoord(affineCoefficients, dataset.RasterXSize, 0, out xMax, out yMax);
        }

        public static void CoordTransform(this OSGeo.OSR.SpatialReference srcSR, OSGeo.OSR.SpatialReference destSR, params double[][] inouts)
        {
            if (srcSR.IsSame(destSR) <= 0)
            {
                using (OSGeo.OSR.CoordinateTransformation coordinateTransformation = new OSGeo.OSR.CoordinateTransformation(srcSR, destSR))
                {
                    foreach (var inout in inouts)
                    {
                        coordinateTransformation.TransformPoint(inout);
                    }
                }
            }
        }
        public static void CoordTransformToWgs84(this OSGeo.OSR.SpatialReference srcSR, params double[][] inouts)
        {
            using (OSGeo.OSR.SpatialReference destSR = new OSGeo.OSR.SpatialReference(""))
            {
                destSR.SetWellKnownGeogCS("EPSG:4326");
                CoordTransform(srcSR, destSR, inouts);
            }
        }
        public static void CoordTransformToWgs84(this OSGeo.OSR.SpatialReference srcSR, ref double x, ref double y)
        {
            using (OSGeo.OSR.SpatialReference destSR = new OSGeo.OSR.SpatialReference(""))
            {
                destSR.SetWellKnownGeogCS("EPSG:4326");
                double[] inout = { x, y };
                CoordTransform(srcSR, destSR, inout);
                x = inout[0];
                y = inout[1];
            }
        }
        public static void CoordTransformToWgs84(this OSGeo.OSR.SpatialReference srcSR, ref double x, ref double y, ref double z)
        {
            using (OSGeo.OSR.SpatialReference destSR = new OSGeo.OSR.SpatialReference(""))
            {
                destSR.SetWellKnownGeogCS("EPSG:4326");
                double[] inout = { x, y, z };
                CoordTransform(srcSR, destSR, inout);
                x = inout[0];
                y = inout[1];
                z = inout[2];
            }
        }
        public static OSGeo.OSR.SpatialReference GetSpatialReference(this Dataset dataset)
        {
            OSGeo.OSR.SpatialReference spatialReference = null;
            if (dataset == null)
            {
                return spatialReference;
            }
            spatialReference = new OSGeo.OSR.SpatialReference(dataset.GetProjection());
            return spatialReference;
        }
        public static void GetSuitableZoom(this Dataset dataset, ref int minZoom, ref int maxZoom)
        {
            string projectionStr = dataset.GetProjection();
            double[] affineParas = new double[6];
            dataset.GetGeoTransform(affineParas);
            double xRes = affineParas[1];
            double yRes = -affineParas[5];
            double resolution = Math.Min(xRes, yRes);
            double dWidth = Math.Max(dataset.RasterXSize * xRes, dataset.RasterYSize * yRes);
            string projcs = null;
            string geogcs = null;
            using (OSGeo.OSR.SpatialReference srcSR = new OSGeo.OSR.SpatialReference(projectionStr))
            {
                projcs = srcSR.GetAttrValue("PROJCS", 0);
                if (string.IsNullOrEmpty(projcs))
                {
                    geogcs = srcSR.GetAttrValue("GEOGCS", 0);
                }
            }
            bool isDegree = projcs == null && geogcs != null;
            bool minZoomSeted = false;
            bool maxZoomSeted = false;
            for (int i = 0; i < 30; i++)
            {
                double tmpResolution = TileMatrix.GetResolution(isDegree, i);
                if (!minZoomSeted)
                {
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
                        minZoomSeted = true;
                    }
                }
                if (!maxZoomSeted)
                {
                    if (resolution >= tmpResolution)
                    {
                        maxZoom = i;
                        maxZoomSeted = true;
                    }
                }
                if (minZoomSeted && maxZoomSeted)
                {
                    break;
                }
            }
        }
        public static LayerType AddToCapabilities(this Dataset dataset, string name, Capabilities capabilities)
        {
            string projectionStr = dataset.GetProjection();
            dataset.GetExtent(out double xMin, out double yMin, out double xMax, out double yMax);
            int minLevel = 0;
            int maxLevel = 19;
            dataset.GetSuitableZoom(ref minLevel, ref maxLevel);
            LayerType layerType = CapabilitiesHelper.AddToCapabilities(capabilities, name, projectionStr, xMin, yMin, xMax, yMax, minLevel, maxLevel);
            string href = capabilities.GetHref(WmtsOperationType.GetTile, WmtsRequestType.REST);
            string tileMatrixSet = null;
            using (var spatialReference = dataset.GetSpatialReference())
            {
                tileMatrixSet = spatialReference.GetAttrValue("GEOGCS", 0);
            }
            URLTemplateType tileTemplate = CapabilitiesHelper.CreateTileResourceURL(href, name, tileMatrixSet);
            layerType.ResourceURL = new URLTemplateType[] { tileTemplate };
            return layerType;
        }

    }
}
