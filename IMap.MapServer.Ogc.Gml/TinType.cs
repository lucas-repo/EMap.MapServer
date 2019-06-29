namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Tin", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TinType : TriangulatedSurfaceType {
        
        private LineStringSegmentType[][] stopLinesField;
        
        private LineStringSegmentType[][] breakLinesField;
        
        private LengthType maxLengthField;
        
        private TinTypeControlPoint controlPointField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LineStringSegment", typeof(LineStringSegmentType), IsNullable=false)]
        public LineStringSegmentType[][] stopLines {
            get {
                return this.stopLinesField;
            }
            set {
                this.stopLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LineStringSegment", typeof(LineStringSegmentType), IsNullable=false)]
        public LineStringSegmentType[][] breakLines {
            get {
                return this.breakLinesField;
            }
            set {
                this.breakLinesField = value;
            }
        }
        
        /// <remarks/>
        public LengthType maxLength {
            get {
                return this.maxLengthField;
            }
            set {
                this.maxLengthField = value;
            }
        }
        
        /// <remarks/>
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
