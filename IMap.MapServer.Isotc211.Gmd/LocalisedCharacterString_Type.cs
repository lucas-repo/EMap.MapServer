namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("LocalisedCharacterString", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class LocalisedCharacterString_Type {
        
        private string idField;
        
        private string localeField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
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
