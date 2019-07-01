namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservationAtDistance", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DirectedObservationAtDistanceType : DirectedObservationType {
        
        private MeasureType distanceField;
        
        
        public MeasureType distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
    }
}
