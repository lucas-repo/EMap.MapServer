namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Clothoid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ClothoidType : AbstractCurveSegmentType {
        
        private ClothoidTypeRefLocation refLocationField;
        
        private decimal scaleFactorField;
        
        private double startParameterField;
        
        private double endParameterField;
        
        /// <remarks/>
        public ClothoidTypeRefLocation refLocation {
            get {
                return this.refLocationField;
            }
            set {
                this.refLocationField = value;
            }
        }
        
        /// <remarks/>
        public decimal scaleFactor {
            get {
                return this.scaleFactorField;
            }
            set {
                this.scaleFactorField = value;
            }
        }
        
        /// <remarks/>
        public double startParameter {
            get {
                return this.startParameterField;
            }
            set {
                this.startParameterField = value;
            }
        }
        
        /// <remarks/>
        public double endParameter {
            get {
                return this.endParameterField;
            }
            set {
                this.endParameterField = value;
            }
        }
    }
}
