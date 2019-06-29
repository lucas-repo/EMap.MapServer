namespace IMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    public partial class Integer_PropertyType {
        
        private string integerField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string Integer {
            get {
                return this.integerField;
            }
            set {
                this.integerField = value;
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
