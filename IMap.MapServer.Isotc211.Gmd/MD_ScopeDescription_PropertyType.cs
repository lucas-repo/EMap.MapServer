namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_ScopeDescription_PropertyType {
        
        private MD_ScopeDescription_Type mD_ScopeDescriptionField;
        
        private string nilReasonField;
        
        
        public MD_ScopeDescription_Type MD_ScopeDescription {
            get {
                return this.mD_ScopeDescriptionField;
            }
            set {
                this.mD_ScopeDescriptionField = value;
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
