namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class GetTile {
        
        private string layerField;
        
        private string styleField;
        
        private string formatField;
        
        private DimensionNameValue[] dimensionNameValueField;
        
        private string tileMatrixSetField;
        
        private string tileMatrixField;
        
        private int tileRowField;
        
        private int tileColField;
        
        private string serviceField;
        
        private string versionField;
        
        public GetTile() {
            this.serviceField = "WMTS";
            this.versionField = "1.0.0";
        }
        
        
        public string Layer {
            get {
                return this.layerField;
            }
            set {
                this.layerField = value;
            }
        }
        
        
        public string Style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DimensionNameValue")]
        public DimensionNameValue[] DimensionNameValue {
            get {
                return this.dimensionNameValueField;
            }
            set {
                this.dimensionNameValueField = value;
            }
        }
        
        
        public string TileMatrixSet {
            get {
                return this.tileMatrixSetField;
            }
            set {
                this.tileMatrixSetField = value;
            }
        }
        
        
        public string TileMatrix {
            get {
                return this.tileMatrixField;
            }
            set {
                this.tileMatrixField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public int TileRow {
            get {
                return this.tileRowField;
            }
            set {
                this.tileRowField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public int TileCol {
            get {
                return this.tileColField;
            }
            set {
                this.tileColField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
