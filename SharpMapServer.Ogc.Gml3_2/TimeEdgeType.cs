namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeEdge", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeEdgeType : AbstractTimeTopologyPrimitiveType {
        
        private TimeNodePropertyType startField;
        
        private TimeNodePropertyType endField;
        
        private TimePeriodPropertyType extentField;
        
        
        public TimeNodePropertyType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        
        public TimeNodePropertyType end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        
        public TimePeriodPropertyType extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
    }
}
