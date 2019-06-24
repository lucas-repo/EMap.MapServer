namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Title", Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class LanguageStringType {
        
        private string langField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
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
