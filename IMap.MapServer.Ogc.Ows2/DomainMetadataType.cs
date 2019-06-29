namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Meaning", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class DomainMetadataType {
        
        private string referenceField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
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
