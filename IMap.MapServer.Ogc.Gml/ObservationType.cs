namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Observation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ObservationType : AbstractFeatureType {
        
        private TimePrimitivePropertyType validTimeField;
        
        private FeaturePropertyType usingField;
        
        private TargetPropertyType targetField;
        
        private AssociationType resultOfField;
        
        /// <remarks/>
        public TimePrimitivePropertyType validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        /// <remarks/>
        public FeaturePropertyType @using {
            get {
                return this.usingField;
            }
            set {
                this.usingField = value;
            }
        }
        
        /// <remarks/>
        public TargetPropertyType target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        public AssociationType resultOf {
            get {
                return this.resultOfField;
            }
            set {
                this.resultOfField = value;
            }
        }
    }
}
