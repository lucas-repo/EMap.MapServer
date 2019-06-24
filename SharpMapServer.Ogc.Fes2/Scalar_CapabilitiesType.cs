namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class Scalar_CapabilitiesType {
        
        private LogicalOperators logicalOperatorsField;
        
        private ComparisonOperatorsType comparisonOperatorsField;
        
        
        public LogicalOperators LogicalOperators {
            get {
                return this.logicalOperatorsField;
            }
            set {
                this.logicalOperatorsField = value;
            }
        }
        
        
        public ComparisonOperatorsType ComparisonOperators {
            get {
                return this.comparisonOperatorsField;
            }
            set {
                this.comparisonOperatorsField = value;
            }
        }
    }
}
