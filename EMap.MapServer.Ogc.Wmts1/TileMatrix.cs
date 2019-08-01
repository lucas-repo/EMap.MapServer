using EMap.MapServer.Ogc.Ows1_1;
using System;

namespace EMap.MapServer.Ogc.Wmts1
{




    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wmts/1.0", IsNullable = false)]
    public partial class TileMatrix : DescriptionType
    {
        /// <summary>
        /// According to OGC SLD 1.0 specification:
        /// The "standardized rendering pixel size" is defined to be 0.28mm × 0.28mm (millimeters).
        /// </summary>
        public const double ScaleHint = 0.00028;
        /// <summary>
        /// 椭球长半轴
        /// </summary>
        public const double Semimajor = 6378137;

        private CodeType identifierField;

        private double scaleDenominatorField;

        private string topLeftCornerField;

        private string tileWidthField;

        private string tileHeightField;

        private string matrixWidthField;

        private string matrixHeightField;


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


        public double ScaleDenominator
        {
            get
            {
                return this.scaleDenominatorField;
            }
            set
            {
                this.scaleDenominatorField = value;
            }
        }


        public string TopLeftCorner
        {
            get
            {
                return this.topLeftCornerField;
            }
            set
            {
                this.topLeftCornerField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string TileWidth
        {
            get
            {
                return this.tileWidthField;
            }
            set
            {
                this.tileWidthField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string TileHeight
        {
            get
            {
                return this.tileHeightField;
            }
            set
            {
                this.tileHeightField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MatrixWidth
        {
            get
            {
                return this.matrixWidthField;
            }
            set
            {
                this.matrixWidthField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MatrixHeight
        {
            get
            {
                return this.matrixHeightField;
            }
            set
            {
                this.matrixHeightField = value;
            }
        }
        #region Functions
        public double GetResolution(bool isDegree)
        {
            double metersPerUnit = 1;
            if (isDegree)
            {
                metersPerUnit = Math.PI * Semimajor / 180;
            }
            double unitsPerPixel = ScaleDenominator * ScaleHint / metersPerUnit;
            return unitsPerPixel;
        }
        public static double GetResolution(bool isDegree, int zoom)
        {
            double unitsPerPixel;
            if (isDegree)
            {
                unitsPerPixel = 360 / (256 * Math.Pow(2, zoom));
            }
            else
            {
                unitsPerPixel = 2 * Math.PI * Semimajor / (256 * Math.Pow(2, zoom));
            }
            return unitsPerPixel;
        }
        public void GetTileIndex(bool isDegree, double x, double y, out int col, out int row)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            double resolution = GetResolution(isDegree);
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            col = (int)((x - left) / (resolution * tileWidth));
            row = (int)((top - y) / (resolution * tileHeight));
        }
        public void GetTileBoundary(bool isDegree, int row, int col, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            double resolution = GetResolution(isDegree);
            xMin = left + col * tileWidth * resolution;
            xMax = left + (col + 1) * tileWidth * resolution;
            yMax = top - row * tileHeight * resolution;
            yMin = top - (row + 1) * tileHeight * resolution;
        }
        public void GetFeatureInfoBoundary(bool isDegree, int row, int col, int j, int i, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            double resolution = GetResolution(isDegree);
            xMin = left + (col * tileWidth + i) * resolution;
            xMax = left + (col * tileWidth + i + 1) * resolution;
            yMax = top - (row * tileHeight + j) * resolution;
            yMin = top - (row * tileHeight + j + 1) * resolution;
        }
        #endregion
    }
}
