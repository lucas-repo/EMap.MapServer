namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeodesicString", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeodesicStringType : AbstractCurveSegmentType {
        
        private object itemField;
        
        private CurveInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        public GeodesicStringType() {
            this.interpolationField = CurveInterpolationType.geodesic;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified {
            get {
                return this.interpolationFieldSpecified;
            }
            set {
                this.interpolationFieldSpecified = value;
            }
        }
    }
}
