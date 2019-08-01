using EMap.MapServer.Ogc.Ows1_1;
using EMap.MapServer.Ogc.Services;
using EMap.MapServer.Ogc.Wmts1;
using EMap.MapServer.Services.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Controllers
{
    //[Route("api/[controller]")]
    [Route("EMap/Services/{serviceName}/MapServer/Wmts")]
    [ApiController]
    public class WmtsController : BaseApiController
    {
        protected Encoding Encoding { get; } = Encoding.UTF8;
        public WmtsController(IHostingEnvironment environment, ConfigContext configContext) : base(environment, configContext)
        {
        }
        #region private functions   
        private async Task<ContentResult> GetCapabilities(string serviceName, GetCapabilities getCapabilities)
        {
            ContentResult result = new ContentResult()
            {
                ContentType = "application/xml"
            };
            int statusCode = 200;
            ExceptionReport exception = null;
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "serviceName", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string version = null;
            if (getCapabilities.AcceptVersions?.Length > 0)
            {
                version = getCapabilities.AcceptVersions[0];
            }
            if (string.IsNullOrWhiteSpace(version))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (version != "1.0.0")
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, version);
            if (serviceRecord == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (!System.IO.File.Exists(serviceRecord.Path))
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            IWmtsService wmtsService = GetWmts1Service(version);
            Capabilities capabilities = wmtsService.GetCapabilities(serviceRecord.Path, getCapabilities);
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                wmtsService.XmlSerialize(sw, capabilities);
            }
            result.Content = sb.ToString();
            goto Success;
        Exception:
            result.Content = XmlHelper.XmlSerialize(exception, Encoding, null);
        Success:
            result.StatusCode = statusCode;
            return result;
        }
        private async Task<ActionResult> GetTile(string serviceName, GetTile getTile)
        {
            ActionResult result = null;
            ExceptionReport exception = null;
            int statusCode = 200;
            #region Validate parameters
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "serviceName", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string serviceType = getTile.service;
            if (string.IsNullOrWhiteSpace(serviceType))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "service", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (serviceType.ToLower() != "wmts")
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string version = getTile.version;
            if (string.IsNullOrWhiteSpace(version))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (version != "1.0.0")
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string layerName = getTile.Layer;
            if (string.IsNullOrWhiteSpace(layerName))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "layer", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string style = getTile.Style;
            if (string.IsNullOrWhiteSpace(style))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "style", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string format = getTile.Format;
            if (string.IsNullOrWhiteSpace(format))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "format", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string tileMatrixSet = getTile.TileMatrixSet;
            if (string.IsNullOrWhiteSpace(tileMatrixSet))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "tileMatrixSet", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string tileMatrix = getTile.TileMatrix;
            if (string.IsNullOrWhiteSpace(tileMatrix))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "tileMatrix", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, version);
            if (serviceRecord == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (!System.IO.File.Exists(serviceRecord.Path))
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            LayerRecord layerRecord = await GetLayerRecord(serviceRecord, layerName);
            if (layerRecord == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            #endregion
            GetCapabilities getCapabilities = new GetCapabilities(version);
            IWmtsService wmts1Service = GetWmts1Service(version);
            Capabilities capabilities = wmts1Service.GetCapabilities(serviceRecord.Path, getCapabilities);
            if (capabilities == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            LayerType layerType = capabilities.GetLayerType(layerRecord.Name);
            if (layerType == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            if (!layerType.Format.Contains(format))
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "format", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (layerType.TileMatrixSetLink == null || layerType.TileMatrixSetLink.Length == 0)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            string layerTileMatrixSetStr = layerType.TileMatrixSetLink[0].TileMatrixSet;
            if (layerTileMatrixSetStr != null)
            {
                TileMatrixSet layerTileMatrixSet = capabilities.Contents.TileMatrixSet?.FirstOrDefault(x => x.Identifier?.Value == layerTileMatrixSetStr);
                if (layerTileMatrixSet != null)
                {
                    TileMatrix layerTileMatrix = layerTileMatrixSet.TileMatrix?.FirstOrDefault(x => x.Identifier.Value == getTile.TileMatrix);
                    if (layerTileMatrix != null)
                    {
                        bool ret = layerTileMatrix.TopLeftCorner.ToPosition(out double left, out double top);
                        if (!ret)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        BoundingBoxType boundingBoxType = layerType.BoundingBox?.Length > 0 ? layerType.BoundingBox[0] : layerType.WGS84BoundingBox?.Length > 0 ? layerType.WGS84BoundingBox[0] : null;
                        if (boundingBoxType == null)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        bool ret0 = boundingBoxType.LowerCorner.ToPosition(out double xMin, out double yMin);
                        bool ret1 = boundingBoxType.UpperCorner.ToPosition(out double xMax, out double yMax);
                        if (!ret0 || !ret1)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        bool isDegree = layerTileMatrixSet.GetIsDegreeByLocalDb();
                        layerTileMatrix.GetTileIndex(isDegree, xMin, yMax, out int startCol, out int startRow);
                        int matrixWidth = Convert.ToInt32(layerTileMatrix.MatrixWidth);
                        int matrixHeight = Convert.ToInt32(layerTileMatrix.MatrixHeight);
                        if (getTile.TileCol < startCol || getTile.TileCol >= startCol + matrixWidth || getTile.TileRow < startRow || getTile.TileRow >= startRow + matrixHeight)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("TileOutOfRange", exceptionText: "Bad request");
                            statusCode = 400;
                            goto Exception;
                        }
                    }
                }
            }
            try
            {
                byte[] tileBuffer = wmts1Service.GetTile(capabilities, layerRecord.Path, getTile);
                result = new FileContentResult(tileBuffer, getTile.Format);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"获取瓦片{getTile.TileMatrix}_{getTile.TileCol}_{getTile.TileRow}失败:{e.Message}");
            }
            goto Success;
        Exception:
            string content = XmlHelper.XmlSerialize(exception, Encoding, null);
            result = new ContentResult()
            {
                StatusCode = statusCode,
                Content = content
            };
        Success:
            return result;
        }
        private async Task<ContentResult> GetFeatureInfo(string serviceName, GetFeatureInfo getFeatureInfo)
        {
            GetTile getTile = getFeatureInfo.GetTile;
            string content = null;
            ExceptionReport exception = null;
            int statusCode = 200;
            #region Validate parameters
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "serviceName", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string serviceType = getTile.service;
            if (string.IsNullOrWhiteSpace(serviceType))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "service", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (serviceType != "wmts")
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string version = getTile.version;
            if (string.IsNullOrWhiteSpace(version))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (version != "1.0.0")
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "version", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string layerName = getTile.Layer;
            if (string.IsNullOrWhiteSpace(layerName))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "layer", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string style = getTile.Style;
            if (string.IsNullOrWhiteSpace(style))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "style", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string format = getTile.Format;
            if (string.IsNullOrWhiteSpace(format))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "format", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string tileMatrixSet = getTile.TileMatrixSet;
            if (string.IsNullOrWhiteSpace(tileMatrixSet))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "tileMatrixSet", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            string tileMatrix = getTile.TileMatrix;
            if (string.IsNullOrWhiteSpace(tileMatrix))
            {
                exception = ExceptionReportHelper.GetExceptionReport("MissingParameterValue", "tileMatrix", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, version);
            if (serviceRecord == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (!System.IO.File.Exists(serviceRecord.Path))
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            LayerRecord layerRecord = await GetLayerRecord(serviceRecord, layerName);
            if (layerRecord == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (!System.IO.File.Exists(layerRecord.Path))
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            #endregion
            GetCapabilities getCapabilities = new GetCapabilities(version);
            IWmtsService wmts1Service = GetWmts1Service(version);
            Capabilities capabilities = wmts1Service.GetCapabilities(serviceRecord.Path, getCapabilities);
            if (capabilities == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            LayerType layerType = capabilities.Contents?.DatasetDescriptionSummary?.FirstOrDefault(x => x.Identifier?.Value == layerName && x is LayerType) as LayerType;
            if (layerType == null)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            if (!layerType.Format.Contains(format))
            {
                exception = ExceptionReportHelper.GetExceptionReport("InvalidParameterValue", "format", exceptionText: "Bad request");
                statusCode = 400;
                goto Exception;
            }
            if (layerType.TileMatrixSetLink == null || layerType.TileMatrixSetLink.Length == 0)
            {
                exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                statusCode = 500;
                goto Exception;
            }
            string layerTileMatrixSetStr = layerType.TileMatrixSetLink[0].TileMatrixSet;
            if (layerTileMatrixSetStr != null)
            {
                TileMatrixSet layerTileMatrixSet = capabilities.Contents.TileMatrixSet?.FirstOrDefault(x => x.Identifier?.Value == layerTileMatrixSetStr);
                if (layerTileMatrixSet != null)
                {
                    TileMatrix layerTileMatrix = layerTileMatrixSet.TileMatrix?.FirstOrDefault(x => x.Identifier.Value == getTile.TileMatrix);
                    if (layerTileMatrix != null)
                    {
                        bool ret = layerTileMatrix.TopLeftCorner.ToPosition(out double left, out double top);
                        if (!ret)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        BoundingBoxType boundingBoxType = layerType.BoundingBox?.Length > 0 ? layerType.BoundingBox[0] : layerType.WGS84BoundingBox?.Length > 0 ? layerType.WGS84BoundingBox[0] : null;
                        if (boundingBoxType == null)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        bool ret1 = boundingBoxType.LowerCorner.ToPosition(out double xMin, out double yMin);
                        bool ret2 = boundingBoxType.UpperCorner.ToPosition(out double xMax, out double yMax);
                        if (!ret1 || !ret2)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("NoApplicableCode", exceptionText: "Internal server error");
                            statusCode = 500;
                            goto Exception;
                        }
                        double tileXMin = 0, tileYMin = 0, tileXMax = 0, tileYMax = 0;
                        int tileWidth = Convert.ToInt32(layerTileMatrix.TileWidth);
                        int tileHeight = Convert.ToInt32(layerTileMatrix.TileHeight);
                        tileXMin = left + getTile.TileCol * tileWidth * layerTileMatrix.ScaleDenominator;
                        tileXMax = left + (getTile.TileCol + 1) * tileWidth * layerTileMatrix.ScaleDenominator;
                        tileYMax = top - getTile.TileRow * tileHeight * layerTileMatrix.ScaleDenominator;
                        tileYMin = top - (getTile.TileRow + 1) * tileHeight * layerTileMatrix.ScaleDenominator;
                        if (tileXMax <= xMin || tileXMin >= xMax || tileYMax <= yMin || tileYMin >= yMax)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("TileOutOfRange", exceptionText: "Bad request");
                            statusCode = 400;
                            goto Exception;
                        }
                        if (getFeatureInfo.I < 0 || getFeatureInfo.I >= tileWidth || getFeatureInfo.J < 0 || getFeatureInfo.J >= tileHeight)
                        {
                            exception = ExceptionReportHelper.GetExceptionReport("PointIJOutOfRange", exceptionText: "Bad request");
                            statusCode = 400;
                            goto Exception;
                        }
                    }
                }
            }
            FeatureInfoResponse featureInfoResponse = wmts1Service.GetFeatureInfo(capabilities, serviceRecord.Path, getFeatureInfo);
            content = XmlHelper.XmlSerialize(featureInfoResponse, Encoding, null);
            goto Success;
        Exception:
            content = XmlHelper.XmlSerialize(exception, Encoding, null);
        Success:
            ContentResult result = new ContentResult()
            {
                StatusCode = statusCode,
                Content = content
            };
            return result;
        }

        #endregion

        #region REST
        [Route("{version}/WMTSCapabilities.xml")]
        public async Task<ActionResult> GetCapabilities(string serviceName, string version)
        {
            GetCapabilities getCapabilities = new GetCapabilities(version);
            ContentResult result = await GetCapabilities(serviceName, getCapabilities);
            return result;
        }
        [Route("{layer}/{style}/{tileMatrixSet}/{tileMatrix}/{tileRow}/{tileCol}.{format}")]
        public async Task<ActionResult> GetTile(string serviceName, string layer, string style, string tileMatrixSet, string tileMatrix, int tileRow, int tileCol, string format)
        {
            string mimeType = $"image/{format}";
            GetTile getTile = GetGetTile(serviceName, layer, style, tileMatrixSet, tileMatrix, tileRow, tileCol, mimeType);
            var result = await GetTile(serviceName, getTile);
            return result;
        }
        private GetTile GetGetTile(string serviceName, string layer, string style, string tileMatrixSet, string tileMatrix, int tileRow, int tileCol, string formatMimeType)
        {
            GetTile getTile = new GetTile()
            {
                service = "WMTS",
                version = "1.0.0",
                Layer = layer,
                Style = style,
                Format = formatMimeType,
                TileMatrixSet = tileMatrixSet,
                TileMatrix = tileMatrix,
                TileRow = tileRow,
                TileCol = tileCol
            };
            return getTile;
        }
        [Route("{layer}/{style}/{tileMatrixSet}/{tileMatrix}/{tileRow}/{tileCol}/{j}/{i}.xml")]
        public async Task<ActionResult> GetFeatureInfo(string serviceName, string layer, string style, string tileMatrixSet, string tileMatrix, int tileRow, int tileCol, int j, int i)
        {
            GetTile getTile = new GetTile()
            {
                service = "WMTS",
                version = "1.0.0",
                Layer = layer,
                Style = style,
                TileMatrixSet = tileMatrixSet,
                TileMatrix = tileMatrix,
                TileRow = tileRow,
                TileCol = tileCol
            };
            string infoFormat = "application/xml";
            GetFeatureInfo getFeatureInfo = new GetFeatureInfo()
            {
                service = "WMTS",
                version = "1.0.0",
                I = i,
                J = j,
                GetTile = getTile,
                InfoFormat = infoFormat
            };
            var result = await GetFeatureInfo(serviceName, getFeatureInfo);
            return result;
        }

        #endregion  

        #region KVP
        public async Task<ActionResult> RequestByKvp(string service = "wmts", string version = "1.0.0", string serviceName = null, string request = "GetCapabilities", string layer = null, string style = "default", string format = null, string tileMatrixSet = null, string tileMatrix = null, int tileRow = 0, int tileCol = 0, int j = 0, int i = 0)
        {
            ActionResult actionResult = null;
            if (version == "1.0.0")
            {
                switch (request.ToLower())
                {
                    case "getcapabilities":
                        actionResult = await GetCapabilities(serviceName, version);
                        break;
                    case "gettile":
                        GetTile getTile = GetGetTile(serviceName, layer, style, tileMatrixSet, tileMatrix, tileRow, tileCol, format);
                        actionResult = await GetTile(serviceName, getTile);
                        break;
                    case "getfeatureinfo":
                        actionResult = await GetFeatureInfo(serviceName, layer, style, tileMatrixSet, tileMatrix, tileRow, tileCol, j, i);
                        break;
                }
            }
            return actionResult;
        }
        #endregion
        protected IWmtsService GetWmts1Service(string version = "1.0.0")
        {
            OgcServiceType serviceType = OgcServiceType.Wmts;
            IWmtsService wmts1Service = OgcServiceHelper.GetOgcService(serviceType, version) as IWmtsService;
            return wmts1Service;
        }
        protected async Task<ServiceRecord> GetServiceRecord(string serviceName, string version)
        {
            ServiceRecord serviceRecord = await ConfigContext.Services.FirstOrDefaultAsync(x => x.Name == serviceName && x.Version == version && x.Type == OgcServiceType.Wmts);
            return serviceRecord;
        }
        protected async Task<LayerRecord> GetLayerRecord(string serviceName, string version, string layerName)
        {
            ServiceRecord serviceRecord = await GetServiceRecord(serviceName, version);
            LayerRecord layerRecord = await GetLayerRecord(serviceRecord, layerName);
            return layerRecord;
        }
        protected async Task<LayerRecord> GetLayerRecord(ServiceRecord serviceRecord, string layerName)
        {
            LayerRecord layerRecord = null;
            if (serviceRecord != null && !string.IsNullOrWhiteSpace(layerName))
            {
                layerRecord = await ConfigContext.Layers.FirstOrDefaultAsync(x => x.ServiceId == serviceRecord.Id && x.Name == layerName);
            }
            return layerRecord;
        }
    }
}