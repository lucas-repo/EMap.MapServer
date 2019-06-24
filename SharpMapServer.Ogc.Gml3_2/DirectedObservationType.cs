namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DirectedObservationType : ObservationType {
        
        private DirectionPropertyType directionField;
        
        
        public DirectionPropertyType direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
    }
}
