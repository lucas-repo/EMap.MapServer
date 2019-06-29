namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Observation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ObservationType : AbstractFeatureType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private ProcedurePropertyType usingField;
        
        private TargetPropertyType targetField;
        
        private ResultType resultOfField;
        
        
        public TimePrimitivePropertyType validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        
        public ProcedurePropertyType @using {
            get {
                return this.usingField;
            }
            set {
                this.usingField = value;
            }
        }
        
        
        public TargetPropertyType target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        
        public ResultType resultOf {
            get {
                return this.resultOfField;
            }
            set {
                this.resultOfField = value;
            }
        }
    }
}
