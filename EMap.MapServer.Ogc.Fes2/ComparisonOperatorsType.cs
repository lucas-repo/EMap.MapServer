namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class ComparisonOperatorsType {
        
        private ComparisonOperatorType[] comparisonOperatorField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("ComparisonOperator")]
        public ComparisonOperatorType[] ComparisonOperator {
            get {
                return this.comparisonOperatorField;
            }
            set {
                this.comparisonOperatorField = value;
            }
        }
    }
}
