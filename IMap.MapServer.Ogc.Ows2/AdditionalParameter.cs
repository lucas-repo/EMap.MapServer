namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class AdditionalParameter {
        
        private CodeType1 nameField;
        
        private object[] valueField;
        
        
        public CodeType1 Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public object[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
