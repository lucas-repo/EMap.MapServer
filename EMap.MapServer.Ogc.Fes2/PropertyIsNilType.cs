namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNil", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class PropertyIsNilType : ComparisonOpsType {
        
        private object expressionField;
        
        private string nilReasonField;
        
        
        public object expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
