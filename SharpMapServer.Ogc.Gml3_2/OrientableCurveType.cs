namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableCurve", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class OrientableCurveType : AbstractCurveType {
        
        private CurvePropertyType baseCurveField;
        
        private SignType orientationField;
        
        public OrientableCurveType() {
            this.orientationField = SignType.Item1;
        }
        
        
        public CurvePropertyType baseCurve {
            get {
                return this.baseCurveField;
            }
            set {
                this.baseCurveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation {
            get {
                return this.orientationField;
            }
            set {
                this.orientationField = value;
            }
        }
    }
}
