namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GridFunction", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GridFunctionType {
        
        private SequenceRuleType sequenceRuleField;
        
        private string startPointField;
        
        
        public SequenceRuleType sequenceRule {
            get {
                return this.sequenceRuleField;
            }
            set {
                this.sequenceRuleField = value;
            }
        }
        
        
        public string startPoint {
            get {
                return this.startPointField;
            }
            set {
                this.startPointField = value;
            }
        }
    }
}
