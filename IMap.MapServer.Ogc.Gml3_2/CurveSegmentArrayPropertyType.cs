namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("segments", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CurveSegmentArrayPropertyType {
        
        private AbstractCurveSegmentType[] abstractCurveSegmentField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractCurveSegment")]
        public AbstractCurveSegmentType[] AbstractCurveSegment {
            get {
                return this.abstractCurveSegmentField;
            }
            set {
                this.abstractCurveSegmentField = value;
            }
        }
    }
}
