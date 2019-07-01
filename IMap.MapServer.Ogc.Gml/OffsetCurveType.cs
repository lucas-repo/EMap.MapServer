namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OffsetCurve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OffsetCurveType : AbstractCurveSegmentType {
        
        private CurvePropertyType offsetBaseField;
        
        private LengthType distanceField;
        
        private VectorType refDirectionField;
        
        /// <remarks/>
        public CurvePropertyType offsetBase {
            get {
                return this.offsetBaseField;
            }
            set {
                this.offsetBaseField = value;
            }
        }
        
        /// <remarks/>
        public LengthType distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
        
        /// <remarks/>
        public VectorType refDirection {
            get {
                return this.refDirectionField;
            }
            set {
                this.refDirectionField = value;
            }
        }
    }
}
