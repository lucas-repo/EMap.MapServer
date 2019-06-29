namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ExceptionReport {
        
        private ExceptionType[] exceptionField;
        
        private string versionField;
        
        private string langField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Exception")]
        public ExceptionType[] Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
}
