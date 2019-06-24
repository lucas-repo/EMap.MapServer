namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResourceByID", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class GetResourceByIdType {
        
        private string[] resourceIDField;
        
        private string outputFormatField;
        
        private string serviceField;
        
        private string versionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("ResourceID", DataType="anyURI")]
        public string[] ResourceID {
            get {
                return this.resourceIDField;
            }
            set {
                this.resourceIDField = value;
            }
        }
        
        
        public string OutputFormat {
            get {
                return this.outputFormatField;
            }
            set {
                this.outputFormatField = value;
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
