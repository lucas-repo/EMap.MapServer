namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class GetFeatureInfo {
        
        private GetTile getTileField;
        
        private int jField;
        
        private int iField;
        
        private string infoFormatField;
        
        private string serviceField;
        
        private string versionField;
        
        public GetFeatureInfo() {
            this.serviceField = "WMTS";
            this.versionField = "1.0.0";
        }
        
        
        public GetTile GetTile {
            get {
                return this.getTileField;
            }
            set {
                this.getTileField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public int J {
            get {
                return this.jField;
            }
            set {
                this.jField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public int I {
            get {
                return this.iField;
            }
            set {
                this.iField = value;
            }
        }
        
        
        public string InfoFormat {
            get {
                return this.infoFormatField;
            }
            set {
                this.infoFormatField = value;
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
