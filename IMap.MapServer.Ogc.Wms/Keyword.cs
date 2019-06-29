namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Keyword {
        
        private string vocabularyField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vocabulary {
            get {
                return this.vocabularyField;
            }
            set {
                this.vocabularyField = value;
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
