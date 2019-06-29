namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class NilValue {
        
        private string reasonField;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
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
