using EMap.MapServer.Ogc.Ows1_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace EMap.MapServer.Ogc.Wmts1
{




    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wmts/1.0", IsNullable = false)]
    public partial class TileMatrixSet : DescriptionType
    {

        private CodeType identifierField;

        private BoundingBoxType boundingBoxField;

        private string supportedCRSField;

        private string wellKnownScaleSetField;

        private TileMatrix[] tileMatrixField;


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public CodeType Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public BoundingBoxType BoundingBox
        {
            get
            {
                return this.boundingBoxField;
            }
            set
            {
                this.boundingBoxField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1", DataType = "anyURI")]
        public string SupportedCRS
        {
            get
            {
                return this.supportedCRSField;
            }
            set
            {
                this.supportedCRSField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string WellKnownScaleSet
        {
            get
            {
                return this.wellKnownScaleSetField;
            }
            set
            {
                this.wellKnownScaleSetField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("TileMatrix")]
        public TileMatrix[] TileMatrix
        {
            get
            {
                return this.tileMatrixField;
            }
            set
            {
                this.tileMatrixField = value;
            }
        }
        #region Functions
        public IEnumerable<TileMatrix> GetTileMatrices(string identifer)
        {
            IEnumerable<TileMatrix> tileMatrices = TileMatrix?.Where(x => x.Identifier.Value == identifer);
            return tileMatrices;
        }
        public TileMatrix GetTileMatrix(string identifer)
        {
            TileMatrix tileMatrix = GetTileMatrices(identifer).FirstOrDefault();
            return tileMatrix;
        }
        public bool GetIsDegreeByWebRequest()
        {
            bool ret = false;
            if (string.IsNullOrEmpty(SupportedCRS))
            {
                return ret;
            }
            string str = SupportedCRS.Replace("urn:ogc:", "");
            string epsgVersion = "9.7";
            string[] array = str.Split(':');
            StringBuilder urlSb = new StringBuilder();
            urlSb.Append("http://www.opengis.net");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 2 && array[i] == "")
                {
                    array[i] = epsgVersion;
                }
                string value = array[i];
                urlSb.Append($"/{value}");
            }
            XElement geodeticCRSEle = XElement.Load(urlSb.ToString());
            if (geodeticCRSEle == null)
            {
                return ret;
            }
            string xmlNamespaceName = "http://www.w3.org/2000/xmlns/";
            string gmlNamespaceName = geodeticCRSEle.Attribute(XName.Get("gml", xmlNamespaceName))?.Value;
            string epsgNamespaceName = geodeticCRSEle.Attribute(XName.Get("epsg", xmlNamespaceName))?.Value;
            if (string.IsNullOrEmpty(gmlNamespaceName) || string.IsNullOrEmpty(epsgNamespaceName))
            {
                return ret;
            }
            IEnumerable<XElement> metaDataPropertyEles = geodeticCRSEle.Elements(XName.Get("metaDataProperty", gmlNamespaceName));
            if (metaDataPropertyEles == null)
            {
                return ret;
            }
            foreach (var metaDataPropertyEle in metaDataPropertyEles)
            {
                XElement commonMetaDataEle = metaDataPropertyEle.Element(XName.Get("CommonMetaData", epsgNamespaceName));
                if (commonMetaDataEle != null)
                {
                    string type = commonMetaDataEle.Element(XName.Get("type", epsgNamespaceName))?.Value;
                    if (type == "geographic 2D")
                    {
                        ret = true;
                    }
                    break;
                }
            }

            return ret;
        }
        public bool GetIsDegreeByLocalDb()
        {
            bool ret = false;
            if (string.IsNullOrEmpty(SupportedCRS) || !SupportedCRS.Contains(":EPSG:"))
            {
                return ret;
            }
            string[] array = SupportedCRS.Split(':');
            bool convertResult = int.TryParse(array[array.Length - 1], out int epsg);
            String projcs = SpatialReferenceHelper.GetProjcs(epsg);
            String geogcs = SpatialReferenceHelper.GetGeogcs(epsg);
            ret = string.IsNullOrEmpty(projcs) && !string.IsNullOrEmpty(geogcs);
            return ret;
        }
        public List<double> GetResolutions(IEnumerable<string> tileMatrixIdentifiers)
        {
            List<double> resolutions = new List<double>();
            bool isDegree = GetIsDegreeByLocalDb();
            foreach (var tileMatrixIdentifier in tileMatrixIdentifiers)
            {
                TileMatrix tileMatrix = TileMatrix.FirstOrDefault(x => x.Identifier.Value == tileMatrixIdentifier);
                if (tileMatrix != null)
                {
                    double res = tileMatrix.GetResolution(isDegree);
                    resolutions.Add(res);
                }
            }
            return resolutions;
        }
        /// <summary>
        /// 获取最佳缩放级别，resolutions必须从0级开始
        /// </summary>
        /// <param name="resolutions"></param>
        /// <param name="xmin"></param>
        /// <param name="ymin"></param>
        /// <param name="xmax"></param>
        /// <param name="ymax"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int? GetSuitableZoom(List<double> resolutions, double xmin, double ymin, double xmax, double ymax, int width, int height)
        {
            int? level = null;
            double? suitableResolution = GetSuitableResolution(resolutions, xmin, ymin, xmax, ymax, width, height);
            if (suitableResolution.HasValue)
            {
                level = resolutions.IndexOf(suitableResolution.Value);
            }
            return level;
        }
        public static double? GetSuitableResolution(List<double> resolutions, double xmin, double ymin, double xmax, double ymax, int width, int height)
        {
            if (resolutions == null || resolutions.Count == 0)
            {
                throw new Exception("resolutions不能为空");
            }
            double? suitableResolution = null;
            double dx = xmax - xmin;
            double dy = ymax - ymin;
            double resolution = Math.Max(dy / height, dx / width);
            for (int i = 0; i < resolutions.Count; i++)
            {
                if (resolution > resolutions[i])
                {
                    if (i == 0)
                    {
                        suitableResolution = resolutions[i];
                    }
                    else
                    {
                        suitableResolution = resolutions[i - 1];
                    }
                    break;
                }
            }
            return suitableResolution;
        }
        #endregion
    }
}
