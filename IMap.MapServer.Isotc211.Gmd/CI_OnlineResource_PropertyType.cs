namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class CI_OnlineResource_PropertyType {
        
        private CI_OnlineResource_Type cI_OnlineResourceField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public CI_OnlineResource_Type CI_OnlineResource {
            get {
                return this.cI_OnlineResourceField;
            }
            set {
                this.cI_OnlineResourceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuidref {
            get {
                return this.uuidrefField;
            }
            set {
                this.uuidrefField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.isotc211.org/2005/gco")]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
