using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Data.Rasters.GdalExtension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMap.MapServer.DotSpatial
{
    public static class DataHelper
    {
        public static List<string> GetSupportedExtensions(string dialogFilter)
        {
            List<string> extensions = new List<string>();
            string[] formats = dialogFilter.Split('|');
            char[] wild = { '*' };

            // We don't care about the description strings, just the extensions.
            for (int i = 1; i < formats.Length; i += 2)
            {
                // Multiple extension types are separated by semicolons
                string[] potentialExtensions = formats[i].Split(';');
                foreach (string potentialExtension in potentialExtensions)
                {
                    string ext = potentialExtension.TrimStart(wild);
                    if (extensions.Contains(ext) == false) extensions.Add(ext);
                }
            }

            return extensions;
        }
        public static IDataSet OpenFile(string dataPath)
        {
            IDataSet dataSet = OpenFeatureSet(dataPath);
            if (dataSet != null)
            {
                return dataSet;
            }
            dataSet = OpenRaster(dataPath);
            return dataSet;
        }
        public static IFeatureSet OpenFeatureSet(string dataPath)
        {
            IFeatureSet dataSet = null;
            string extension = Path.GetExtension(dataPath);
            ShapefileDataProvider shapefileDataProvider = new ShapefileDataProvider();
            if (GetSupportedExtensions(shapefileDataProvider.DialogReadFilter).Contains(extension))
            {
                dataSet = shapefileDataProvider.Open(dataPath);
            }
            return dataSet;
        }
        public static IRaster OpenRaster(string dataPath)
        {
            IRaster dataSet = null;
            string extension = Path.GetExtension(dataPath);
            GdalRasterProvider gdalRasterProvider = new GdalRasterProvider();
            if (GetSupportedExtensions(gdalRasterProvider.DialogReadFilter).Contains(extension))
            {
                dataSet = gdalRasterProvider.Open(dataPath);
                return dataSet;
            }
            return dataSet;
        }
        public static IMapLayer GetMapLayer(string dataPath)
        {
            IMapLayer mapLayer = null;
            IDataSet dataSet = OpenFile(dataPath);
            if (dataSet != null)
            {
                if (dataSet is IFeatureSet featureSet)
                {
                    switch (featureSet.FeatureType)
                    {
                        case FeatureType.Point:
                        case FeatureType.MultiPoint:
                            mapLayer = new MapPointLayer(featureSet);
                            break;
                        case FeatureType.Line:
                            mapLayer = new MapLineLayer(featureSet);
                            break;
                        case FeatureType.Polygon:
                            mapLayer = new MapPolygonLayer(featureSet);
                            break;
                    }
                }
                else if (dataSet is IImageData imageSet)
                {
                    mapLayer = new MapImageLayer(imageSet);
                }
                else if (dataSet is IRaster raster)
                {
                    mapLayer = new MapRasterLayer(raster);
                }
                else if (dataSet is ISelfLoadSet selfLoadSet)
                {
                    mapLayer = selfLoadSet.GetLayer();
                }
            }
            return mapLayer;
        }
    }
}
