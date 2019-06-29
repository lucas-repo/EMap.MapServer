namespace IMap.MapServer.Ogc {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class ServiceExceptionType {
        
        private string codeField;
        
        private string locatorField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
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
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
