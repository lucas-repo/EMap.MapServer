using EMap.MapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public static class CapabilitiesExtension
    {
        public static TileMatrixSet GetLayerTileMatrixSet(this Capabilities capabilities, string layerName)
        {
            TileMatrixSet tileMatrixSet = null;
            LayerType layerType = capabilities.GetLayerType(layerName);
            if (layerType == null)
            {
                return tileMatrixSet;
            }
            string destTileMatrixSetName = layerType.TileMatrixSetLink.FirstOrDefault()?.TileMatrixSet;
            if (string.IsNullOrEmpty(destTileMatrixSetName))
            {
                return tileMatrixSet;
            }
            tileMatrixSet = capabilities.GetTileMatrixSet(destTileMatrixSetName);
            return tileMatrixSet;
        }
        public static double[] GetTopLeftCorner(this Capabilities capabilities, string layerName, string tileMatrixSetName = null)
        {
            double[] topLeftCorner = null;
            TileMatrixSet tileMatrixSet = null;
            if (!string.IsNullOrEmpty(tileMatrixSetName))
            {
                tileMatrixSet = capabilities.GetTileMatrixSet(tileMatrixSetName);
            }
            else
            {
                tileMatrixSet = capabilities.GetLayerTileMatrixSet(layerName);
            }
            if (tileMatrixSet == null)
            {
                return topLeftCorner;
            }
            topLeftCorner = tileMatrixSet.TileMatrix.FirstOrDefault()?.TopLeftCorner?.ToDoubleValues();
            return topLeftCorner;
        }
        public static double[] GetResolutions(this Capabilities capabilities, string layerName, string tileMatrixSetName = null)
        {
            double[] topLeftCorner = null;
            TileMatrixSet tileMatrixSet = null;
            if (!string.IsNullOrEmpty(tileMatrixSetName))
            {
                tileMatrixSet = capabilities.GetTileMatrixSet(tileMatrixSetName);
            }
            else
            {
                tileMatrixSet = capabilities.GetLayerTileMatrixSet(layerName);
            }
            if (tileMatrixSet == null)
            {
                return topLeftCorner;
            }
            topLeftCorner = tileMatrixSet.TileMatrix.FirstOrDefault()?.TopLeftCorner?.ToDoubleValues();
            return topLeftCorner;
        }
    }
}
