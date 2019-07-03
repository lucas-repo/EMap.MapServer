namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Exception", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ExceptionType {
        
        private string[] exceptionTextField;
        
        private string exceptionCodeField;
        
        private string locatorField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("ExceptionText")]
        public string[] ExceptionText {
            get {
                return this.exceptionTextField;
            }
            set {
                this.exceptionTextField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exceptionCode {
            get {
                return this.exceptionCodeField;
            }
            set {
                this.exceptionCodeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string locator {
            get {
                return this.locatorField;
            }
            set {
                this.locatorField = value;
            }
        }
    }
}
