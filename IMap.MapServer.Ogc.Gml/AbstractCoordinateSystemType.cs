namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateSystemType : AbstractCoordinateSystemBaseType {
        
        private IdentifierType[] csIDField;
        
        private StringOrRefType remarksField;
        
        private CoordinateSystemAxisRefType[] usesAxisField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("csID")]
        public IdentifierType[] csID {
            get {
                return this.csIDField;
            }
            set {
                this.csIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("usesAxis")]
        public CoordinateSystemAxisRefType[] usesAxis {
            get {
                return this.usesAxisField;
            }
            set {
                this.usesAxisField = value;
            }
        }
    }
}
