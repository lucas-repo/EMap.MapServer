namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class SequenceRuleType {
        
        private IncrementOrder orderField;
        
        private bool orderFieldSpecified;
        
        private string[] axisOrderField;
        
        private SequenceRuleEnumeration valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IncrementOrder order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderSpecified {
            get {
                return this.orderFieldSpecified;
            }
            set {
                this.orderFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] axisOrder {
            get {
                return this.axisOrderField;
            }
            set {
                this.axisOrderField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public SequenceRuleEnumeration Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
