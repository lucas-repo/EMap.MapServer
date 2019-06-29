namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("OffsetCurve", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class OffsetCurveType : AbstractCurveSegmentType {
        
        private CurvePropertyType offsetBaseField;
        
        private LengthType distanceField;
        
        private VectorType refDirectionField;
        
        
        public CurvePropertyType offsetBase {
            get {
                return this.offsetBaseField;
            }
            set {
                this.offsetBaseField = value;
            }
        }
        
        
        public LengthType distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
        
        
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
