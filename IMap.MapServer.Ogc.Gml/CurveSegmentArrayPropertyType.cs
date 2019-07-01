namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("segments", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CurveSegmentArrayPropertyType {
        
        private AbstractCurveSegmentType[] _CurveSegmentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_CurveSegment")]
        public AbstractCurveSegmentType[] _CurveSegment {
            get {
                return this._CurveSegmentField;
            }
            set {
                this._CurveSegmentField = value;
            }
        }
    }
}
