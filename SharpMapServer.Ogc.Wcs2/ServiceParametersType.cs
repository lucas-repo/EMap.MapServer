namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceParameters", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class ServiceParametersType {
        
        private System.Xml.XmlQualifiedName coverageSubtypeField;
        
        private CoverageSubtypeParentType coverageSubtypeParentField;
        
        private string nativeFormatField;
        
        private ExtensionType extensionField;
        
        
        public System.Xml.XmlQualifiedName CoverageSubtype {
            get {
                return this.coverageSubtypeField;
            }
            set {
                this.coverageSubtypeField = value;
            }
        }
        
        
        public CoverageSubtypeParentType CoverageSubtypeParent {
            get {
                return this.coverageSubtypeParentField;
            }
            set {
                this.coverageSubtypeParentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string nativeFormat {
            get {
                return this.nativeFormatField;
            }
            set {
                this.nativeFormatField = value;
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
