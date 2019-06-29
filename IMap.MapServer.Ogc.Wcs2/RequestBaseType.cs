namespace IMap.MapServer.Ogc.Wcs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetCoverageType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    public abstract partial class RequestBaseType {
        
        private ExtensionType extensionField;
        
        private string serviceField;
        
        private string versionField;
        
        public RequestBaseType() {
            this.serviceField = "WCS";
        }
        
        
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
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
