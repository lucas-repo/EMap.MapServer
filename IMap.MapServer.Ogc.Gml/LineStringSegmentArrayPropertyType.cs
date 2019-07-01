namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class LineStringSegmentArrayPropertyType {
        
        private LineStringSegmentType[] lineStringSegmentField;
        
        /// <remarks/>
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
