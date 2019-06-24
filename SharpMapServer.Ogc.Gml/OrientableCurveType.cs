namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableCurve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OrientableCurveType : AbstractCurveType {
        
        private CurvePropertyType baseCurveField;
        
        private SignType orientationField;
        
        public OrientableCurveType() {
            this.orientationField = SignType.Item1;
        }
        
        /// <remarks/>
        public CurvePropertyType baseCurve {
            get {
                return this.baseCurveField;
            }
            set {
                this.baseCurveField = value;
            }
        }
        
        /// <remarks/>
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
