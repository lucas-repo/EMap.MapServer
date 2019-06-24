namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeEdge", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeEdgeType : AbstractTimeTopologyPrimitiveType {
        
        private TimeNodePropertyType startField;
        
        private TimeNodePropertyType endField;
        
        private TimePeriodPropertyType extentField;
        
        /// <remarks/>
        public TimeNodePropertyType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        /// <remarks/>
        public TimeNodePropertyType end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        /// <remarks/>
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
