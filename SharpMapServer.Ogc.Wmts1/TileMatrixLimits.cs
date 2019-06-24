namespace SharpMapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrixLimits {
        
        private string tileMatrixField;
        
        private string minTileRowField;
        
        private string maxTileRowField;
        
        private string minTileColField;
        
        private string maxTileColField;
        
        
        public string TileMatrix {
            get {
                return this.tileMatrixField;
            }
            set {
                this.tileMatrixField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MinTileRow {
            get {
                return this.minTileRowField;
            }
            set {
                this.minTileRowField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxTileRow {
            get {
                return this.maxTileRowField;
            }
            set {
                this.maxTileRowField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MinTileCol {
            get {
                return this.minTileColField;
            }
            set {
                this.minTileColField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxTileCol {
            get {
                return this.maxTileColField;
            }
            set {
                this.maxTileColField = value;
            }
        }
    }
}
