namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EllipsoidType : EllipsoidBaseType {
        
        private IdentifierType[] ellipsoidIDField;
        
        private StringOrRefType remarksField;
        
        private MeasureType semiMajorAxisField;
        
        private SecondDefiningParameterType secondDefiningParameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ellipsoidID")]
        public IdentifierType[] ellipsoidID {
            get {
                return this.ellipsoidIDField;
            }
            set {
                this.ellipsoidIDField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        public MeasureType semiMajorAxis {
            get {
                return this.semiMajorAxisField;
            }
            set {
                this.semiMajorAxisField = value;
            }
        }
        
        /// <remarks/>
        public SecondDefiningParameterType secondDefiningParameter {
            get {
                return this.secondDefiningParameterField;
            }
            set {
                this.secondDefiningParameterField = value;
            }
        }
    }
}
