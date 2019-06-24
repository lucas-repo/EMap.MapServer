namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeodeticCRSType : AbstractCRSType {
        
        private object itemField;
        
        private GeodeticDatumPropertyType geodeticDatumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof(CartesianCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("ellipsoidalCS", typeof(EllipsoidalCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("sphericalCS", typeof(SphericalCSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public GeodeticDatumPropertyType geodeticDatum {
            get {
                return this.geodeticDatumField;
            }
            set {
                this.geodeticDatumField = value;
            }
        }
    }
}
