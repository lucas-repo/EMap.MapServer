using System;
using System.Collections.Generic;
using System.Text;
using SharpMapServer.Ogc.Wmts1;
using OSGeo.GDAL;
using OSGeo.OGR;
using SharpMapServer.Ogc.Ows1_1;
using System.IO;
using System.Linq;

namespace SharpMapServer.Ogc.Services.Gdals
{
    public class GdalWmtsService : WmtsService, IGdalWmtsService
    {
        public static readonly string[] SupportRasters;
        public static readonly List<string> SupportVevtors;
        static GdalWmtsService()
        {
            Gdal.AllRegister();
            // 为了支持中文路径，请添加下面这句代码  
            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "NO");
            // 为了使属性表字段支持中文，请添加下面这句  
            Gdal.SetConfigOption("SHAPE_ENCODING", "");
            Ogr.RegisterAll();
            if (SupportRasters == null)
            {
                SupportRasters = new string[]
                {
                    ".gen",".thf",".adf",".blx",".xlb",".bag",".bmp",".kap",".bt",".doq",".ecw",".hdr",".img",".ers",".n1",".fits","gif",".grb",".gta",".tif","gtx",".gxf",".mem",".jpg",".jp2",".j2k",".nat",".ntf",".png",".ppm",".pgm",".rik",".rsw",".mtw",".ter",".til",".vrt",".xpm"
                };
            }
        }
        private LanguageStringType[] GetLanguageStringType(string name)
        {
            LanguageStringType[] languageStringTypes = new LanguageStringType[]
            {
                new LanguageStringType()
                {
                    Value = name
                }
            };
            return languageStringTypes;
        }
        private LayerType GetLayerType(Dataset dataset, string name)
        {
            LayerType layerType = null; 
            if (dataset == null)
            {
                return layerType;
            }
            LanguageStringType[] titles = GetLanguageStringType(name);
            LanguageStringType[] abstracts = GetLanguageStringType(name);
            double[] argout = new double[6];
            dataset.GetGeoTransform(argout);
            double xRes = argout[1];
            double yRes = argout[5];
            double xMin = argout[0];
            double xMax = xMin + xRes * dataset.RasterXSize;
            double yMax = argout[3];
            double yMin = yMax + yRes * dataset.RasterYSize;

            BoundingBoxType[] boundingBoxs = new BoundingBoxType[]
            {
                new BoundingBoxType()
                {
                    LowerCorner =$"{xMin} {yMin}",
                    UpperCorner =$"{xMax} {yMax}"
                }
            };
            WGS84BoundingBoxType[] WGS84BoundingBoxes = null;
            string projection = dataset.GetProjection();
            SpatialReference srcSR = new SpatialReference(projection); 
             SpatialReference destSR = new SpatialReference("");
            string projectName = srcSR.GetAttrValue("PROJCS", 0);
            destSR.SetWellKnownGeogCS("EPSG:4326");
            if (srcSR.IsSame(destSR)<=0)
            {
                CoordinateTransformation coordinateTransformation = new CoordinateTransformation(srcSR, destSR);
                double[] leftBottom = { xMin, yMin };
                double[] topRight = { xMax, yMax };
                coordinateTransformation.TransformPoint(leftBottom);
                coordinateTransformation.TransformPoint(topRight);
                xMin = leftBottom[0];
                yMin = leftBottom[1];
                xMax = topRight[0];
                yMax = topRight[1];
            }
            srcSR.Dispose();
            destSR.Dispose();
            WGS84BoundingBoxes = new WGS84BoundingBoxType[]
            {
                new WGS84BoundingBoxType()
                {
                    LowerCorner=$"{xMin} {yMin}",
                    UpperCorner=$"{xMax} {yMax}"
                }
            };
            CodeType identifier = new CodeType()
            {
                Value = name
            };
            Style style = new Style()
            {
                isDefault = true,
                Identifier = new CodeType()
                {
                    Value = "default"
                }
            };
            Style[] styles = new Style[]
            {
                style
            };
            string[] formats = new string[]
            {
                "image/png","image/jpg"
            };
            TileMatrixSetLink[] tileMatrixSetLinks = new TileMatrixSetLink[]
            {
                new TileMatrixSetLink()
                {
                     TileMatrixSet=projectName
                }
            };
            layerType = new LayerType()
            {
                Title = titles,
                Abstract = abstracts,
                BoundingBox = boundingBoxs,
                WGS84BoundingBox = WGS84BoundingBoxes,
                Identifier = identifier,
                Style = styles,
                Format = formats,
                TileMatrixSetLink = tileMatrixSetLinks
            };
            return layerType;
        }
        private LayerType GetLayerType(DataSource dataSource)
        {
            throw new NotImplementedException();
        }
        private LayerType GetLayerType(string dataPath)
        {
            LayerType layerType = null;
            string name = Path.GetFileNameWithoutExtension(dataPath);
            Dataset dataset = Gdal.Open(dataPath, Access.GA_ReadOnly); 
            if (dataset != null)
            {
                layerType = GetLayerType(dataset, name);
                dataset.Dispose();
            }
            else
            {
                DataSource dataSource = Ogr.Open(dataPath, 0);
                layerType = GetLayerType(dataSource);
            }
            return layerType;
        }
        public override LayerType AddContent(Capabilities capabilities, string dataPath)
        {
            throw new NotImplementedException();
            //LayerType layerType = null;
            //if (capabilities == null || dataSet == null)
            //{
            //    return layerType;
            //}
            //if (capabilities.Contents == null)
            //{
            //    capabilities.Contents = new ContentsType();
            //}
            //DatasetDescriptionSummaryBaseType[] datasets = capabilities.Contents.DatasetDescriptionSummary;
            //if (datasets?.Any(x => x.Identifier.Value == dataSet.Name) == true)
            //{
            //    return layerType;
            //}
            //int layerCount = datasets == null ? 1 : datasets.Length + 1;
            //capabilities.Contents.DatasetDescriptionSummary = new DatasetDescriptionSummaryBaseType[layerCount];
            //datasets?.CopyTo(capabilities.Contents.DatasetDescriptionSummary, 0);
            //datasets = capabilities.Contents.DatasetDescriptionSummary;
            //layerType = GetLayerType(dataSet);
            //datasets[datasets.Length - 1] = layerType;

            //TileMatrixSet[] tileMatrixSets = capabilities.Contents.TileMatrixSet;
            //if (tileMatrixSets?.Any(x => x.Identifier.Value == dataSet.Projection.Name) != true)
            //{
            //    int tileMatrixSetCount = tileMatrixSets == null ? 1 : tileMatrixSets.Length + 1;
            //    capabilities.Contents.TileMatrixSet = new TileMatrixSet[tileMatrixSetCount];
            //    tileMatrixSets?.CopyTo(capabilities.Contents.TileMatrixSet, 0);
            //    tileMatrixSets = capabilities.Contents.TileMatrixSet;
            //    int minLevel = 0;
            //    int maxLevel = 20;

            //    TileMatrix[] tileMatrices = GetTileMatrices(dataSet, minLevel, maxLevel);
            //    TileMatrixSet tileMatrixSet = new TileMatrixSet()
            //    {
            //        Identifier = new CodeType()
            //        {
            //            Value = dataSet.Projection.Name
            //        },
            //        SupportedCRS = "urn:ogc:def:crs:OGC:1.3:CRS84",//TODO 待修改
            //        TileMatrix = tileMatrices
            //    };
            //    tileMatrixSets[tileMatrixSets.Length - 1] = tileMatrixSet;
            //}
            //return layerType;
        }


        public override FeatureInfoResponse GetFeatureInfo(string path, GetFeatureInfo getFeatureInfo)
        {
            throw new NotImplementedException();
        }

        public override byte[] GetTile(Capabilities capabilities, string path, GetTile getTile)
        {
            throw new NotImplementedException();
        }
    }
}
