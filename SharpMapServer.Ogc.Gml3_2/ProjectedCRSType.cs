namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType {
        
        private object itemField;
        
        private CartesianCSPropertyType cartesianCSField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("baseGeodeticCRS", typeof(GeodeticCRSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("baseGeographicCRS", typeof(GeographicCRSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public CartesianCSPropertyType cartesianCS {
            get {
                return this.cartesianCSField;
            }
            set {
                this.cartesianCSField = value;
            }
        }
    }
}
