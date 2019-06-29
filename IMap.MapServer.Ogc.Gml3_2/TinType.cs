namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Tin", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TinType : SurfaceType {
        
        private LineStringSegmentArrayPropertyType[] stopLinesField;
        
        private LineStringSegmentArrayPropertyType[] breakLinesField;
        
        private LengthType maxLengthField;
        
        private TinTypeControlPoint controlPointField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("stopLines")]
        public LineStringSegmentArrayPropertyType[] stopLines {
            get {
                return this.stopLinesField;
            }
            set {
                this.stopLinesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("breakLines")]
        public LineStringSegmentArrayPropertyType[] breakLines {
            get {
                return this.breakLinesField;
            }
            set {
                this.breakLinesField = value;
            }
        }
        
        
        public LengthType maxLength {
            get {
                return this.maxLengthField;
            }
            set {
                this.maxLengthField = value;
            }
        }
        
        
        public TinTypeControlPoint controlPoint {
            get {
                return this.controlPointField;
            }
            set {
                this.controlPointField = value;
            }
        }
    }
}
