using EMap.MapServer.Extensions;
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
        public double GetResolution()
        {
            int dpi = 96;
            double resolution = 0.0254 * ScaleDenominator / dpi;
            return resolution;
        }
        public void GetTileIndex(double x, double y, out int col, out int row)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            double resolution = GetResolution();
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            col = (int)((x - left) / (resolution * tileWidth));
            row = (int)((top - y) / (resolution * tileHeight));
        }
        public void GetTileBoundary(int row, int col, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            double resolution = GetResolution();
            xMin = left + col * tileWidth * resolution;
            xMax = left + (col + 1) * tileWidth * resolution;
            yMax = top - row * tileHeight * resolution;
            yMin = top - (row + 1) * tileHeight * resolution;
        }
        public void GetFeatureInfoBoundary(int row, int col, int j, int i, out double xMin, out double yMin, out double xMax, out double yMax)
        {
            bool ret = TopLeftCorner.ToPosition(out double left, out double top);
            int tileWidth = Convert.ToInt32(TileWidth);
            int tileHeight = Convert.ToInt32(TileHeight);
            double resolution = GetResolution();
            xMin = left + (col * tileWidth + i) * resolution;
            xMax = left + (col * tileWidth + i + 1) * resolution;
            yMax = top - (row * tileHeight + j) * resolution;
            yMin = top - (row * tileHeight + j + 1) * resolution;
        }
        #endregion
    }
}
