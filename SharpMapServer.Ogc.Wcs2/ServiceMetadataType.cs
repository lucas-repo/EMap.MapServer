namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceMetadata", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class ServiceMetadataType {
        
        private string[] formatSupportedField;
        
        private ExtensionType extensionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("formatSupported", DataType="anyURI")]
        public string[] formatSupported {
            get {
                return this.formatSupportedField;
            }
            set {
                this.formatSupportedField = value;
            }
        }
        
        
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
}
