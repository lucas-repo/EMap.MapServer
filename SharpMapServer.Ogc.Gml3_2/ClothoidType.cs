namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Clothoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ClothoidType : AbstractCurveSegmentType {
        
        private ClothoidTypeRefLocation refLocationField;
        
        private decimal scaleFactorField;
        
        private double startParameterField;
        
        private double endParameterField;
        
        private CurveInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        public ClothoidType() {
            this.interpolationField = CurveInterpolationType.clothoid;
        }
        
        
        public ClothoidTypeRefLocation refLocation {
            get {
                return this.refLocationField;
            }
            set {
                this.refLocationField = value;
            }
        }
        
        
        public decimal scaleFactor {
            get {
                return this.scaleFactorField;
            }
            set {
                this.scaleFactorField = value;
            }
        }
        
        
        public double startParameter {
            get {
                return this.startParameterField;
            }
            set {
                this.startParameterField = value;
            }
        }
        
        
        public double endParameter {
            get {
                return this.endParameterField;
            }
            set {
                this.endParameterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurveInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        
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
