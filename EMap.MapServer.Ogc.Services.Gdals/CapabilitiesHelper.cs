using EMap.MapServer.Ogc.Ows1_1;
using EMap.MapServer.Ogc.Wmts1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EMap.MapServer.Ogc.Services.Gdals
{
    /// <summary>
    /// Capabilities的辅助方法
    /// </summary>
    public static class CapabilitiesHelper
    {
        public static LanguageStringType[] CreateLanguageStringTypes(string name)
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
        public static TileMatrixSetLink[] CreateTileMatrixSetLinks(string projectName)
        {
            TileMatrixSetLink[] tileMatrixSetLinks = new TileMatrixSetLink[]
            {
                new TileMatrixSetLink()
                {
                     TileMatrixSet=projectName
                }
            };
            return tileMatrixSetLinks;
        }
        public static BoundingBoxType[] CreateBoundingBoxTypes(double xMin, double yMin, double xMax, double yMax)
        {
            BoundingBoxType[] boundingBoxTypes = new BoundingBoxType[]
            {
                new BoundingBoxType()
                {
                    LowerCorner =$"{xMin} {yMin}",
                    UpperCorner =$"{xMax} {yMax}"
                }
            };
            return boundingBoxTypes;
        }
        public static WGS84BoundingBoxType[] CreateWGS84BoundingBoxTypes(double xMin, double yMin, double xMax, double yMax)
        {
            WGS84BoundingBoxType[] boundingBoxTypes = new WGS84BoundingBoxType[]
            {
                new WGS84BoundingBoxType()
                {
                    LowerCorner =$"{xMin} {yMin}",
                    UpperCorner =$"{xMax} {yMax}"
                }
            };
            return boundingBoxTypes;
        }
        public static Style[] CreateStyles(bool isDefault, string identifier)
        {
            Style[] styles = new Style[]
            {
                new Style()
                {
                    isDefault = isDefault,
                    Identifier = new CodeType()
                    {
                        Value = identifier
                    }
                }
            };
            return styles;
        }

        public static TileMatrix[] CreateTileMatrices(double semimajor, bool isDegree, double xMin, double yMin, double xMax, double yMax, int minLevel = 0, int maxLevel = 18, int tileWidth = 256, int tileHeight = 256)
        {
            double extentWidth = xMax - xMin;
            double extentHeight = yMax - yMin;
            List<TileMatrix> tileMatrices = new List<TileMatrix>();
            {
                double metersPerUnit;
                if (isDegree)
                {
                    metersPerUnit = Math.PI * 6356752.314245179 / 180;
                }
                else
                {
                    metersPerUnit = 1;
                }
                for (int i = minLevel; i <= maxLevel; i++)
                {
                    double unitsPerPixel;
                    double scaleDenominator;
                    if (isDegree)
                    {
                        unitsPerPixel = 360.0 / (Math.Pow(2, i) * 256);
                        scaleDenominator = unitsPerPixel * metersPerUnit / TileMatrix.ScaleHint;
                    }
                    else
                    {
                        unitsPerPixel = 2 * Math.PI * semimajor / (Math.Pow(2, i) * tileWidth);
                        scaleDenominator = unitsPerPixel * metersPerUnit / TileMatrix.ScaleHint;
                    }
                    double tileDWidth = 256 * unitsPerPixel;
                    double tileDHeight = tileDWidth;
                    int colStart = 0;
                    int colEnd = (int)Math.Floor(extentWidth / tileDWidth);
                    int matrixWidth = colEnd - colStart + 1;
                    int rowStart = 0;
                    int rowEnd = (int)Math.Floor(extentHeight / tileDHeight);
                    int matrixHeight = rowEnd - rowStart + 1;
                    TileMatrix tileMatrix = new TileMatrix()
                    {
                        Identifier = new CodeType()
                        {
                            Value = i.ToString()
                        },
                        ScaleDenominator = scaleDenominator,
                        TopLeftCorner = $"{xMin} {yMax}",
                        TileWidth = tileWidth.ToString(),
                        TileHeight = tileHeight.ToString(),
                        MatrixWidth = matrixWidth.ToString(),
                        MatrixHeight = matrixHeight.ToString()
                    };
                    tileMatrices.Add(tileMatrix);
                }
            }
            return tileMatrices.ToArray();
        }
        public static LayerType CreateLayerType(string name)
        {
            LanguageStringType[] titles = CreateLanguageStringTypes(name);
            LanguageStringType[] abstracts = CreateLanguageStringTypes(name);
            CodeType identifier = new CodeType()
            {
                Value = name
            };
            Style[] styles = CreateStyles(true, "default");
            string[] formats = new string[]
            {
                "image/png","image/jpeg"
            };
            LayerType layerType = new LayerType()
            {
                Title = titles,
                Abstract = abstracts,
                Identifier = identifier,
                Style = styles,
                Format = formats
            };
            return layerType;
        }
        public static URLTemplateType CreateTileResourceURL(string href, string name, string tileMatrixSet, string style = "default", string format = "png")
        {
            URLTemplateType getTileResourceURL = new URLTemplateType()
            {
                format = $"image/{format}",
                resourceType = "tile",
                template = $"{href}/{name}/{style}/{tileMatrixSet}/{{TileMatrix}}/{{TileRow}}/{{TileCol}}.{format}"
            };
            return getTileResourceURL;
        }
        public static URLTemplateType CreateFeatureInfoResourceURL(string href, string name, string tileMatrixSet, string style = "default")
        {
            URLTemplateType getFeatureInfoResourceURL = new URLTemplateType()
            {
                format = "application/gml+xml; version=3.1",
                resourceType = "FeatureInfo",
                template = $"{href}/{name}/{style}/{tileMatrixSet}/{{TileMatrix}}/{{TileRow}}/{{TileCol}}/{{J}}/{{I}}.xml"
            };
            return getFeatureInfoResourceURL;
        }


        public static LayerType AddToCapabilities(Capabilities capabilities, string name, string projectionStr, double xMin, double yMin, double xMax, double yMax, int minLevel, int maxLevel)
        {
            LayerType layerType = null;
            if (capabilities == null || capabilities == null || minLevel < 0 || minLevel > maxLevel)
            {
                return layerType;
            }
            if (capabilities.Contents == null)
            {
                capabilities.Contents = new ContentsType();
            }
            DatasetDescriptionSummaryBaseType[] datasets = capabilities.Contents.DatasetDescriptionSummary;
            if (datasets?.Any(x => x.Identifier.Value == name) == true)
            {
                return layerType;
            }
            int layerCount = datasets == null ? 1 : datasets.Length + 1;
            capabilities.Contents.DatasetDescriptionSummary = new DatasetDescriptionSummaryBaseType[layerCount];
            datasets?.CopyTo(capabilities.Contents.DatasetDescriptionSummary, 0);
            datasets = capabilities.Contents.DatasetDescriptionSummary;

            #region 获取layerType
            layerType = CreateLayerType(name);
            string projcs = null;
            string geogcs = null;
            double semimajor;
            BoundingBoxType[] boundingBoxs = CreateBoundingBoxTypes(xMin, yMin, xMax, yMax);
            WGS84BoundingBoxType[] WGS84BoundingBoxes = null;

            using (OSGeo.OSR.SpatialReference srcSR = new OSGeo.OSR.SpatialReference(projectionStr))
            {
                semimajor = srcSR.GetSemiMajor();
                projcs = srcSR.GetAttrValue("PROJCS", 0);
                if (string.IsNullOrEmpty(projcs))
                {
                    geogcs = srcSR.GetAttrValue("GEOGCS", 0);
                }
                using (OSGeo.OSR.SpatialReference destSR = new OSGeo.OSR.SpatialReference(""))
                {
                    destSR.SetWellKnownGeogCS("EPSG:4326");
                    double WGS84XMin = xMin;
                    double WGS84YMin = yMin;
                    double WGS84XMax = xMax;
                    double WGS84YMax = yMax;
                    if (srcSR.IsSame(destSR) != 1)
                    {
                        double[] leftBottom = { xMin, yMin };
                        double[] topRight = { xMax, yMax };
                        srcSR.CoordTransform(destSR, leftBottom, topRight);
                        WGS84XMin = leftBottom[0];
                        WGS84YMin = leftBottom[1];
                        WGS84XMax = topRight[0];
                        WGS84YMax = topRight[1];
                    }
                    WGS84BoundingBoxes = CreateWGS84BoundingBoxTypes(WGS84XMin, WGS84YMin, WGS84XMax, WGS84YMax);
                }
            }
            string tileMatrixSetName = !string.IsNullOrEmpty(projcs) ? projcs : geogcs;
            TileMatrixSetLink[] tileMatrixSetLinks = CreateTileMatrixSetLinks(tileMatrixSetName);
            layerType.BoundingBox = boundingBoxs;
            layerType.WGS84BoundingBox = WGS84BoundingBoxes;
            layerType.TileMatrixSetLink = tileMatrixSetLinks;
            #endregion
            datasets[datasets.Length - 1] = layerType;

            #region 设置tileMatrixSet
            TileMatrixSet[] tileMatrixSets = capabilities.Contents.TileMatrixSet;
            if (tileMatrixSets?.Any(x => x.Identifier.Value == tileMatrixSetName) != true)
            {
                int tileMatrixSetCount = tileMatrixSets == null ? 1 : tileMatrixSets.Length + 1;
                capabilities.Contents.TileMatrixSet = new TileMatrixSet[tileMatrixSetCount];
                tileMatrixSets?.CopyTo(capabilities.Contents.TileMatrixSet, 0);
                tileMatrixSets = capabilities.Contents.TileMatrixSet;
                bool isDegree = projcs == null;
                TileMatrix[] tileMatrices = CreateTileMatrices(semimajor, isDegree, xMin, yMin, xMax, yMax, minLevel, maxLevel);

                int? wkid = null;
                if (!string.IsNullOrEmpty(projcs))
                {
                    wkid = SpatialReferenceHelper.GetWellKnownWkidFromProjecs(projcs);
                }
                else if (!string.IsNullOrEmpty(geogcs))
                {
                    wkid = SpatialReferenceHelper.GetWellKnownWkidFromGeogcs(geogcs);
                }
                if (wkid.HasValue)
                {
                    TileMatrixSet tileMatrixSet = new TileMatrixSet()
                    {
                        Identifier = new CodeType()
                        {
                            Value = tileMatrixSetName
                        },
                        SupportedCRS = $"urn:ogc:def:crs:EPSG::{wkid.Value}",//TODO 待修改 根据名称获取EPSG，网上下载arcgis的
                        TileMatrix = tileMatrices
                    };
                    tileMatrixSets[tileMatrixSets.Length - 1] = tileMatrixSet;
                }
            }
            #endregion
            return layerType;
        }
    }
}
