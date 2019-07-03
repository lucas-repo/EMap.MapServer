using OSGeo.GDAL;
using EMap.MapServer.Ogc.Ows1_1;
using EMap.MapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EMap.MapServer.Ogc.Services.Gdals
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


        public static LayerType AddToCapabilities(this Dataset dataset, Capabilities capabilities)
        {
            string fileName = dataset.GetDescription();//todo 需处理中文乱码
            string name = Path.GetFileNameWithoutExtension(fileName);
            string projectionStr = dataset.GetProjection();
            dataset.GetExtent(out double xMin, out double yMin, out double xMax, out double yMax);
            LayerType layerType = CapabilitiesHelper.AddToCapabilities(capabilities, name, projectionStr, xMin, yMin, xMax, yMax);
            return layerType;
        }
    }
}
