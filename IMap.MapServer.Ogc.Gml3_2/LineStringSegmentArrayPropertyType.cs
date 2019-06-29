namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class LineStringSegmentArrayPropertyType {
        
        private LineStringSegmentType[] lineStringSegmentField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("LineStringSegment")]
        public LineStringSegmentType[] LineStringSegment {
            get {
                return this.lineStringSegmentField;
            }
            set {
                this.lineStringSegmentField = value;
            }
        }
    }
}
