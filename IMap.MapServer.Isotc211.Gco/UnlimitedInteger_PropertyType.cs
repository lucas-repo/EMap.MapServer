namespace IMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    public partial class UnlimitedInteger_PropertyType {
        
        private UnlimitedInteger_Type unlimitedIntegerField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnlimitedInteger_Type UnlimitedInteger {
            get {
                return this.unlimitedIntegerField;
            }
            set {
                this.unlimitedIntegerField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
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
