namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsEqualTo", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class BinaryComparisonOpType : ComparisonOpsType {
        
        private object[] expressionField;
        
        private bool matchCaseField;
        
        private MatchActionType matchActionField;
        
        public BinaryComparisonOpType() {
            this.matchCaseField = true;
            this.matchActionField = MatchActionType.Any;
        }
        
        
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
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase {
            get {
                return this.matchCaseField;
            }
            set {
                this.matchCaseField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MatchActionType.Any)]
        public MatchActionType matchAction {
            get {
                return this.matchActionField;
            }
            set {
                this.matchActionField = value;
            }
        }
    }
}
