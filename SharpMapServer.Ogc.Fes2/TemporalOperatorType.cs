namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class TemporalOperatorType {
        
        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable=false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands {
            get {
                return this.temporalOperandsField;
            }
            set {
                this.temporalOperandsField = value;
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
