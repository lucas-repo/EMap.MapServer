using SharpMapServer.Extensions;
using SharpMapServer.Ogc.Ows1_1;
using SharpMapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpMapServer.Ogc.Services
{
    public static class WmtsHelper
    {
        public static bool ComputeTileBoundary(LayerType layerType, TileMatrix layerTileMatrix, int tileCol, int tileRow, out double tileXMin, out double tileYMin, out double tileXMax, out double tileYMax)
        {
            bool result = false;
            tileXMin = 0;
            tileYMin = 0;
            tileXMax = 0;
            tileYMax = 0;
            if (layerType == null || layerTileMatrix == null)
            {
                return result;
            }
            bool ret0 = layerTileMatrix.TopLeftCorner.ToPosition(out double left, out double top);
            if (!ret0)
            {
                return result;
            }
            BoundingBoxType boundingBoxType = layerType.BoundingBox?.Length > 0 ? layerType.BoundingBox[0] : layerType.WGS84BoundingBox?.Length > 0 ? layerType.WGS84BoundingBox[0] : null;
            if (boundingBoxType == null)
            {
                return result;
            }
            bool ret1 = boundingBoxType.LowerCorner.ToPosition(out double xMin, out double yMin);
            bool ret2 = boundingBoxType.UpperCorner.ToPosition(out double xMax, out double yMax);
            if (!ret1 || !ret2)
            {
                return result;
            }
            int tileWidth = Convert.ToInt32(layerTileMatrix.TileWidth);
            int tileHeight = Convert.ToInt32(layerTileMatrix.TileHeight);
            tileXMin = left + tileCol * tileWidth * layerTileMatrix.ScaleDenominator;
            tileXMax = left + (tileCol + 1) * tileWidth * layerTileMatrix.ScaleDenominator;
            tileYMax = top - tileRow * tileHeight * layerTileMatrix.ScaleDenominator;
            tileYMin = top - (tileRow + 1) * tileHeight * layerTileMatrix.ScaleDenominator;
            result = true;
            return result;
        }
        public static bool GetTileIndexByProjection(double originX, double originY, double semimajor, int level, double x, double y, out int col, out int row, double falseEasting = 0, double falseNorthing = 0)
        {
            WebMercatorHelper.WebMercator2LonLat(x, y, out double longitude, out double latitude, falseEasting, falseNorthing);
            double resolution = GetResolution(semimajor, level, latitude);
            bool ret = GetTileIndex(originX, originY, resolution, x, y, out col, out row);
            return ret;
        }

        public static bool GetTileIndexByGeographic(double originX, double originY, double semimajor, int level, double longitude, double latitude, out int col, out int row)
        {
            double resolution = GetResolution(semimajor, level, latitude);
            bool ret = GetTileIndex(originX, originY, resolution, longitude, latitude, out col, out row);
            return ret;
        }
        public static bool GetTileIndex(double originX, double originY, double resolution, double x, double y, out int col, out int row, int tileWidth = 256, int tileHeight = 256)
        {
            bool ret = false;
            col = -1;
            row = -1;
            if (x >= originX && y <= originY)
            {
                double dx = resolution * tileWidth;
                double dy = resolution * tileHeight;
                col = (int)Math.Floor((x - originX) / dx);
                row = (int)Math.Floor((originY - y) / dy);
                ret = true;
            }
            return ret;
        }
        public static double GetResolution(double semimajor, int level, double latitude = 0)
        {
            double perimeter = 2 * Math.PI * semimajor;
            double resolution = Math.Cos(latitude * Math.PI / 180) * perimeter / (256 * Math.Pow(2, level));
            return resolution;
        }
    }
}
