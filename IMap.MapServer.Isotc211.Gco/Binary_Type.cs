namespace IMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("Binary", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
    public partial class Binary_Type {
        
        private string srcField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
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
