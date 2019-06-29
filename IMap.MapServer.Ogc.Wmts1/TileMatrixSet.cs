using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrixSet : DescriptionType {
        
        private CodeType identifierField;
        
        private BoundingBoxType boundingBoxField;
        
        private string supportedCRSField;
        
        private string wellKnownScaleSetField;
        
        private TileMatrix[] tileMatrixField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public BoundingBoxType BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1", DataType="anyURI")]
        public string SupportedCRS {
            get {
                return this.supportedCRSField;
            }
            set {
                this.supportedCRSField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string WellKnownScaleSet {
            get {
                return this.wellKnownScaleSetField;
            }
            set {
                this.wellKnownScaleSetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("TileMatrix")]
        public TileMatrix[] TileMatrix {
            get {
                return this.tileMatrixField;
            }
            set {
                this.tileMatrixField = value;
            }
        }
    }
}
