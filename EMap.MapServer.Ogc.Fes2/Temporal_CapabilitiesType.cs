namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class Temporal_CapabilitiesType {
        
        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;
        
        private TemporalOperatorType[] temporalOperatorsField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable=false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands {
            get {
                return this.temporalOperandsField;
            }
            set {
                this.temporalOperandsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperator", IsNullable=false)]
        public TemporalOperatorType[] TemporalOperators {
            get {
                return this.temporalOperatorsField;
            }
            set {
                this.temporalOperatorsField = value;
            }
        }
    }
}
