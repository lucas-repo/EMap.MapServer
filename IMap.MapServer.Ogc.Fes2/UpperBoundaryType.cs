namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class UpperBoundaryType {
        
        private object expressionField;
        
        
        public object expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
    }
}
