namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservationAtDistance", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DirectedObservationAtDistanceType : DirectedObservationType {
        
        private MeasureType distanceField;
        
        /// <remarks/>
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
