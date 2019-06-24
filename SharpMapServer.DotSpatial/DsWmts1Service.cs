using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Data.Rasters.GdalExtension;
using DotSpatial.Symbology;
using SharpMapServer.Extensions;
using SharpMapServer.Ogc.Ows1_1;
using SharpMapServer.Ogc.Services;
using SharpMapServer.Ogc.Wmts1;

namespace SharpMapServer.DotSpatial
{
    public class DsWmts1Service : WmtsService, IDsWmts1Service
    {
        private GdalImageProvider _provider;
        public GdalImageProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new GdalImageProvider();
                }
                return _provider;
            }
        }
        public override Capabilities CreateCapabilities(string href)
        {
            Capabilities capabilities = CapabilitiesHelper.CreateCapabilities(href);
            return capabilities;
        }

        public override LayerType AddContent(Capabilities capabilities, string dataPath)
        {
            string extension = Path.GetExtension(dataPath);
            if (string.IsNullOrWhiteSpace(extension))
            {
                throw new Exception("不支持的路径");
            }
            IDataSet dataSet = DataHelper.OpenFile(dataPath);
            if (dataSet == null)
            {
                throw new Exception("打开数据失败");
            }
            LayerType layerType= CapabilitiesHelper.AddContent(capabilities, dataSet);
            return layerType;
        }

        public override FeatureInfoResponse GetFeatureInfo(string path, GetFeatureInfo getFeatureInfo)
        {
            throw new NotImplementedException();
        }

        public override byte[] GetTile(Capabilities capabilities, string path, GetTile getTile)
        {
            byte[] buffer = null;
            if (capabilities == null || string.IsNullOrWhiteSpace(path) || getTile == null)
            {
                return buffer;
            }
            IMapLayer mapLayer = DataHelper.GetMapLayer(path);
            if (mapLayer != null)
            {
                LayerType layerType = capabilities.Contents?.DatasetDescriptionSummary?.FirstOrDefault(x => x.Identifier?.Value == getTile.Layer && x is LayerType) as LayerType;
                if (layerType != null)
                {
                    BoundingBoxType boundingBoxType = layerType.BoundingBox?.Length > 0 ? layerType.BoundingBox[0] : layerType.WGS84BoundingBox?.Length > 0 ? layerType.WGS84BoundingBox[0] : null;
                    string layerTileMatrixSetStr = layerType.TileMatrixSetLink[0].TileMatrixSet;
                    TileMatrixSet layerTileMatrixSet = capabilities.Contents.TileMatrixSet?.FirstOrDefault(x => x.Identifier?.Value == layerTileMatrixSetStr);
                    TileMatrix layerTileMatrix = layerTileMatrixSet.TileMatrix?.FirstOrDefault(x => x.Identifier.Value == getTile.TileMatrix);

                    if (layerTileMatrix != null)
                    {
                        bool ret = WmtsHelper.ComputeTileBoundary(layerType, layerTileMatrix, getTile.TileCol, getTile.TileRow, out double tileXMin, out double tileYMin, out double tileXMax, out double tileYMax);
                        if (ret)
                        {
                            Extent extent = new Extent(tileXMin, tileYMin, tileXMax, tileYMax);
                            int tileWidth = Convert.ToInt32(layerTileMatrix.TileWidth);
                            int tileHeight = Convert.ToInt32(layerTileMatrix.TileHeight);
                            Rectangle rectangle = new Rectangle(0, 0, tileWidth, tileHeight);
                            using (Bitmap bmp = GetBitmap(mapLayer, extent, rectangle))
                            {
                                ImageFormat imageFormat = null;
                                if (string.IsNullOrWhiteSpace(getTile.Format) || !getTile.Format.Contains('/'))
                                {
                                    imageFormat = ImageFormat.Png;
                                }
                                else
                                {
                                    string[] formatMimeArray = getTile.Format.Split('/');
                                    switch (formatMimeArray[1])
                                    {
                                        case "jpg":
                                            imageFormat = ImageFormat.Jpeg;
                                            break;
                                        default:
                                            imageFormat = ImageFormat.Png;
                                            break;
                                    }
                                }
                                buffer = GetBitmapBuffer(bmp, imageFormat);
                            }
                        }
                    }
                }
                mapLayer.Dispose();
            }
            return buffer;
        }
        public static Bitmap GetBitmap(IMapLayer mapLayer, Extent extent, Rectangle rectangle)
        {
            Bitmap bmp = new Bitmap(rectangle.Width, rectangle.Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                MapArgs mapArgs = new MapArgs(rectangle, extent, graphics);
                List<Extent> extents = new List<Extent>() { extent };
                mapLayer.DrawRegions(mapArgs, extents, false);
            }
            return bmp;
        }
        public static byte[] GetBitmapBuffer(Bitmap bitmap, ImageFormat imageFormat)
        {
            byte[] buffer = null;
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, imageFormat);
                buffer = ms.ToArray();
            }
            return buffer;
        }
    }
}
