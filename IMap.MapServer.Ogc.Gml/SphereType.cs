namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Sphere", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SphereType : AbstractGriddedSurfaceType {
        
        private CurveInterpolationType horizontalCurveTypeField;
        
        private bool horizontalCurveTypeFieldSpecified;
        
        private CurveInterpolationType verticalCurveTypeField;
        
        private bool verticalCurveTypeFieldSpecified;
        
        public SphereType() {
            this.horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
            this.verticalCurveTypeField = CurveInterpolationType.circularArc3Points;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType horizontalCurveType {
            get {
                return this.horizontalCurveTypeField;
            }
            set {
                this.horizontalCurveTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalCurveTypeSpecified {
            get {
                return this.horizontalCurveTypeFieldSpecified;
            }
            set {
                this.horizontalCurveTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType verticalCurveType {
            get {
                return this.verticalCurveTypeField;
            }
            set {
                this.verticalCurveTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verticalCurveTypeSpecified {
            get {
                return this.verticalCurveTypeFieldSpecified;
            }
            set {
                this.verticalCurveTypeFieldSpecified = value;
            }
        }
    }
}
