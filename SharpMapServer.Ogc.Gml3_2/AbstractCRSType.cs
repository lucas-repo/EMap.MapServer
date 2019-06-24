namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractCRSType : IdentifiedObjectType {
        
        private domainOfValidity[] domainOfValidityField;
        
        private string[] scopeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("domainOfValidity")]
        public domainOfValidity[] domainOfValidity {
            get {
                return this.domainOfValidityField;
            }
            set {
                this.domainOfValidityField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("scope")]
        public string[] scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
    }
}
