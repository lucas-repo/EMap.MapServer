namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Sphere", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SphereType : AbstractGriddedSurfaceType {
        
        private CurveInterpolationType horizontalCurveTypeField;
        
        private bool horizontalCurveTypeFieldSpecified;
        
        private CurveInterpolationType verticalCurveTypeField;
        
        private bool verticalCurveTypeFieldSpecified;
        
        public SphereType() {
            this.horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
            this.verticalCurveTypeField = CurveInterpolationType.circularArc3Points;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType horizontalCurveType {
            get {
                return this.horizontalCurveTypeField;
            }
            set {
                this.horizontalCurveTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horizontalCurveTypeSpecified {
            get {
                return this.horizontalCurveTypeFieldSpecified;
            }
            set {
                this.horizontalCurveTypeFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType verticalCurveType {
            get {
                return this.verticalCurveTypeField;
            }
            set {
                this.verticalCurveTypeField = value;
            }
        }
        
        
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
