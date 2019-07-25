using System;
using System.Collections.Generic;
using System.Text;
using EMap.MapServer.Ogc.Wmts1;
using OSGeo.GDAL;
using OSGeo.OGR;
using EMap.MapServer.Ogc.Ows1_1;
using System.IO;
using System.Linq;
using EMap.Gis.Symbology;
using EMap.MapServer.Extensions;
using SixLabors.Primitives;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp;
using EMap.MapServer.Ogc.Gml;

namespace EMap.MapServer.Ogc.Services.Gdals
{
    public class GdalWmtsService : WmtsService, IGdalWmtsService
    {
        public override LayerType AddContent(Capabilities capabilities, string dataPath)
        {
            LayerType layerType = null;
            if (capabilities == null)
            {
                return layerType;
            }
            string name = Path.GetFileNameWithoutExtension(dataPath);
            try
            {
                using (Dataset dataset = Gdal.Open(dataPath, Access.GA_ReadOnly))
                {
                    if (dataset != null)
                    {
                        layerType = dataset.AddToCapabilities(name, capabilities);
                    }
                }
            }
            catch (Exception e)
            {
                try
                {
                    using (DataSource dataSource = Ogr.Open(dataPath, 0))
                    {
                        if (dataSource != null)
                        {
                            layerType = dataSource.AddToCapabilities(name, capabilities);
                        }
                    }
                }
                catch (Exception exc)
                { }
            }
            return layerType;
        }


        public override FeatureInfoResponse GetFeatureInfo(Capabilities capabilities, string path, GetFeatureInfo getFeatureInfo)
        {
            FeatureInfoResponse featureInfoResponse = null;
            if (capabilities == null || string.IsNullOrEmpty(path) || getFeatureInfo == null)
            {
                return featureInfoResponse;
            }
            LayerFactory layerFactory = new LayerFactory();

            #region 验证getTile参数
            GetTile getTile = getFeatureInfo.GetTile;
            LayerType layerType = capabilities.GetLayerType(getTile.Layer);
            if (layerType == null)
            {
                return featureInfoResponse;
            }
            TileMatrixSet tileMatrixSet = capabilities.GetTileMatrixSet(getTile.TileMatrixSet);
            if (tileMatrixSet == null)
            {
                return featureInfoResponse;
            }
            TileMatrix tileMatrix = tileMatrixSet.GetTileMatrix(getTile.TileMatrix);
            if (tileMatrix == null)
            {
                return featureInfoResponse;
            }
            BoundingBoxType boundingBoxType = layerType.BoundingBox.FirstOrDefault();
            if (boundingBoxType == null)
            {
                return featureInfoResponse;
            }
            bool ret = boundingBoxType.LowerCorner.ToPosition(out double xMin, out double yMin);
            if (!ret)
            {
                return featureInfoResponse;
            }
            ret = boundingBoxType.UpperCorner.ToPosition(out double xMax, out double yMax);
            if (!ret)
            {
                return featureInfoResponse;
            }
            tileMatrix.GetTileIndex(xMin, yMax, out int startCol, out int startRow);
            int matrixWidth = Convert.ToInt32(tileMatrix.MatrixWidth);
            int matrixHeight = Convert.ToInt32(tileMatrix.MatrixHeight);
            if (getTile.TileCol < startCol || getTile.TileCol >= startCol + matrixWidth || getTile.TileRow < startRow || getTile.TileRow >= startRow + matrixHeight)
            {
                return featureInfoResponse;
            }
            if (!layerType.Style.Any(x => x.Identifier.Value == getTile.Style))
            {
                return featureInfoResponse;
            }
            #endregion

            #region 验证getFeatureInfo参数
            int tileWidth = Convert.ToInt32(tileMatrix.TileWidth);
            int tileHeight = Convert.ToInt32(tileMatrix.TileHeight);
            if (getFeatureInfo.J < 0 || getFeatureInfo.J >= tileHeight || getFeatureInfo.I < 0 || getFeatureInfo.I >= tileWidth)
            {
                return featureInfoResponse;
            }
            #endregion

            using (var dataSource = LayerFactory.OpenDataSource(path))
            {
                if (dataSource == null)
                {
                    return featureInfoResponse;
                }
                using (var layer = dataSource.GetLayerByName(getTile.Layer))
                {
                    if (layer == null)
                    {
                        return featureInfoResponse;
                    }
                    tileMatrix.GetFeatureInfoBoundary(getTile.TileRow, getTile.TileCol, getFeatureInfo.J, getFeatureInfo.I, out double ftInfoXMin, out double ftInfoYMin, out double ftInfoXMax, out double ftInfoYMax);
                    layer.SetSpatialFilterRect(ftInfoXMin, ftInfoYMin, ftInfoXMax, ftInfoYMax);
                    FeatureCollectionType featureCollectionType = new FeatureCollectionType();
                    featureInfoResponse = new FeatureInfoResponse()
                    {
                         Item= featureCollectionType
                    };
                    var ft = layer.GetNextFeature();
                    while (ft != null)
                    {
                        ft = layer.GetNextFeature();
                        //todo添加查询的feature
                    }
                }
            }
            return featureInfoResponse;
        }

        public override byte[] GetTile(Capabilities capabilities, string path, GetTile getTile)
        {
            byte[] buffer = null;
            if (capabilities == null || string.IsNullOrEmpty(path) || getTile == null)
            {
                return buffer;
            }
            LayerFactory layerFactory = new LayerFactory();

            #region 验证getTile参数
            LayerType layerType = capabilities.GetLayerType(getTile.Layer);
            if (layerType == null)
            {
                return buffer;
            }
            TileMatrixSet tileMatrixSet = capabilities.GetTileMatrixSet(getTile.TileMatrixSet);
            if (tileMatrixSet == null)
            {
                return buffer;
            }
            TileMatrix tileMatrix = tileMatrixSet.GetTileMatrix(getTile.TileMatrix);
            if (tileMatrix == null)
            {
                return buffer;
            }
            BoundingBoxType boundingBoxType = layerType.BoundingBox.FirstOrDefault();
            if (boundingBoxType == null)
            {
                return buffer;
            }
            bool ret = boundingBoxType.LowerCorner.ToPosition(out double xMin, out double yMin);
            if (!ret)
            {
                return buffer;
            }
            ret = boundingBoxType.UpperCorner.ToPosition(out double xMax, out double yMax);
            if (!ret)
            {
                return buffer;
            }
            tileMatrix.GetTileIndex(xMin, yMax, out int startCol, out int startRow);
            int matrixWidth = Convert.ToInt32(tileMatrix.MatrixWidth);
            int matrixHeight = Convert.ToInt32(tileMatrix.MatrixHeight);
            if (getTile.TileCol < startCol || getTile.TileCol >= startCol + matrixWidth || getTile.TileRow < startRow || getTile.TileRow >= startRow + matrixHeight)
            {
                return buffer;
            }
            if (!layerType.Style.Any(x => x.Identifier.Value == getTile.Style))
            {
                return buffer;
            }
            if (!layerType.Format.Contains(getTile.Format))
            {
                return buffer;
            }
            #endregion

            using (var layer = layerFactory.OpenLayer(path))
            {
                if (layer == null)
                {
                    return buffer;
                }
                tileMatrix.GetTileBoundary(getTile.TileRow, getTile.TileCol, out double tileXMin, out double tileYMin, out double tileXMax, out double tileYMax);
                using (Envelope envelope = new Envelope())
                {
                    envelope.MinX = tileXMin;
                    envelope.MinY = tileYMin;
                    envelope.MaxX = tileXMax;
                    envelope.MaxY = tileYMax;
                    int tileWidth = Convert.ToInt32(tileMatrix.TileWidth);
                    int tileHeight = Convert.ToInt32(tileMatrix.TileHeight);
                    Rectangle rectangle = new Rectangle(0, 0, tileWidth, tileHeight);
                    using (var image = layer.GetImage(envelope, rectangle))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            string formatName = getTile.Format.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                            switch (formatName)
                            {
                                case "png":
                                    image.SaveAsPng(ms);
                                    break;
                                case "jpeg":
                                    image.SaveAsJpeg(ms);
                                    break;
                                default:
                                    return buffer;
                            }
                            buffer = ms.ToArray();
                        }
                    }
                }
            }
            return buffer;
        }
    }
}
