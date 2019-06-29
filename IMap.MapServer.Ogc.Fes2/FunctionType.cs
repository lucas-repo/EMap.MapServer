namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class FunctionType {
        
        private object[] expressionField;
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public object[] expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
