namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("EngineeringCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class EngineeringCRSType : AbstractCRSType {
        
        private object itemField;
        
        private EngineeringDatumPropertyType engineeringDatumField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("affineCS", typeof(AffineCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof(CartesianCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("coordinateSystem", typeof(CoordinateSystemPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("cylindricalCS", typeof(CylindricalCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("linearCS", typeof(LinearCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("polarCS", typeof(PolarCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("sphericalCS", typeof(SphericalCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("userDefinedCS", typeof(UserDefinedCSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public EngineeringDatumPropertyType engineeringDatum {
            get {
                return this.engineeringDatumField;
            }
            set {
                this.engineeringDatumField = value;
            }
        }
    }
}
