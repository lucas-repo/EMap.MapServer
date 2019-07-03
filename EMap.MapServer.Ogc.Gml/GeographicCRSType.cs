namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeographicCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeographicCRSType : AbstractReferenceSystemType {
        
        private EllipsoidalCSRefType usesEllipsoidalCSField;
        
        private GeodeticDatumRefType usesGeodeticDatumField;
        
        /// <remarks/>
        public EllipsoidalCSRefType usesEllipsoidalCS {
            get {
                return this.usesEllipsoidalCSField;
            }
            set {
                this.usesEllipsoidalCSField = value;
            }
        }
        
        /// <remarks/>
        public GeodeticDatumRefType usesGeodeticDatum {
            get {
                return this.usesGeodeticDatumField;
            }
            set {
                this.usesGeodeticDatumField = value;
            }
        }
    }
}
