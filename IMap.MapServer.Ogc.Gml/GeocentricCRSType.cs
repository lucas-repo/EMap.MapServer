namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeocentricCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeocentricCRSType : AbstractReferenceSystemType {
        
        private object itemField;
        
        private GeodeticDatumRefType usesGeodeticDatumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof(CartesianCSRefType))]
        [System.Xml.Serialization.XmlElementAttribute("usesSphericalCS", typeof(SphericalCSRefType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
