using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrix : DescriptionType {
        
        private CodeType identifierField;
        
        private double scaleDenominatorField;
        
        private string topLeftCornerField;
        
        private string tileWidthField;
        
        private string tileHeightField;
        
        private string matrixWidthField;
        
        private string matrixHeightField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        public double ScaleDenominator {
            get {
                return this.scaleDenominatorField;
            }
            set {
                this.scaleDenominatorField = value;
            }
        }
        
        
        public string TopLeftCorner {
            get {
                return this.topLeftCornerField;
            }
            set {
                this.topLeftCornerField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string TileWidth {
            get {
                return this.tileWidthField;
            }
            set {
                this.tileWidthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string TileHeight {
            get {
                return this.tileHeightField;
            }
            set {
                this.tileHeightField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MatrixWidth {
            get {
                return this.matrixWidthField;
            }
            set {
                this.matrixWidthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MatrixHeight {
            get {
                return this.matrixHeightField;
            }
            set {
                this.matrixHeightField = value;
            }
        }
    }
}
