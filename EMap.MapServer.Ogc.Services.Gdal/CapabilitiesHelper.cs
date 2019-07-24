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

        public static TileMatrix[] CreateTileMatrices(double semimajor, double xMin, double yMin, double xMax, double yMax, int minLevel = 0, int maxLevel = 18, int tileWidth = 256, int tileHeight = 256)
        {
            double extentWidth = xMax - xMin;
            double extentHeight = yMax - yMin;
            int dpi = 96;
            List<TileMatrix> tileMatrices = new List<TileMatrix>();
            {
                for (int i = minLevel; i <= maxLevel; i++)
                {
                    double resolution = Math.PI * semimajor / (128 * Math.Pow(2, i));
                    double scaleDenominator = resolution * dpi / 0.0254;
                    double tileDWidth = Math.PI * semimajor / Math.Pow(2, i - 1);
                    double tileDHeight = tileDWidth;
                    int matrixWidth = (int)Math.Ceiling(extentWidth / tileDWidth);
                    int matrixHeight = (int)Math.Ceiling(extentHeight / tileDHeight);
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
                format = "image/{format}",
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


        public static LayerType AddToCapabilities(Capabilities capabilities, string name, string projectionStr, double xMin, double yMin, double xMax, double yMax)
        {
            LayerType layerType = null;
            if (capabilities == null || capabilities == null)
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
            string projectName = null;
            double semimajor;
            BoundingBoxType[] boundingBoxs = CreateBoundingBoxTypes(xMin, yMin, xMax, yMax);
            WGS84BoundingBoxType[] WGS84BoundingBoxes = null;

            using (OSGeo.OSR.SpatialReference srcSR = new OSGeo.OSR.SpatialReference(projectionStr))
            {
                semimajor = srcSR.GetSemiMajor();
                projectName = srcSR.GetAttrValue("PROJCS", 0);
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

            TileMatrixSetLink[] tileMatrixSetLinks = CreateTileMatrixSetLinks(projectName);
            layerType.BoundingBox = boundingBoxs;
            layerType.WGS84BoundingBox = WGS84BoundingBoxes;
            layerType.TileMatrixSetLink = tileMatrixSetLinks;
            #endregion
            datasets[datasets.Length - 1] = layerType;

            #region 设置tileMatrixSet
            TileMatrixSet[] tileMatrixSets = capabilities.Contents.TileMatrixSet;
            if (tileMatrixSets?.Any(x => x.Identifier.Value == projectName) != true)
            {
                int tileMatrixSetCount = tileMatrixSets == null ? 1 : tileMatrixSets.Length + 1;
                capabilities.Contents.TileMatrixSet = new TileMatrixSet[tileMatrixSetCount];
                tileMatrixSets?.CopyTo(capabilities.Contents.TileMatrixSet, 0);
                tileMatrixSets = capabilities.Contents.TileMatrixSet;
                int minLevel = 0;
                int maxLevel = 20;
                TileMatrix[] tileMatrices = CreateTileMatrices(semimajor, xMin, yMin, xMax, yMax, minLevel, maxLevel);
                TileMatrixSet tileMatrixSet = new TileMatrixSet()
                {
                    Identifier = new CodeType()
                    {
                        Value = projectName
                    },
                    SupportedCRS = "urn:ogc:def:crs:OGC:1.3:CRS84",//TODO 待修改
                    TileMatrix = tileMatrices
                };
                tileMatrixSets[tileMatrixSets.Length - 1] = tileMatrixSet;
            }
            #endregion
            return layerType;
        }
    }
}
