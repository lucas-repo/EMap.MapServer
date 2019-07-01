namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNull", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class PropertyIsNullType : ComparisonOpsType {
        
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
