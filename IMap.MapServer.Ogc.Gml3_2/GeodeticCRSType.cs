namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GeodeticCRSType : AbstractCRSType {
        
        private object itemField;
        
        private GeodeticDatumPropertyType geodeticDatumField;
        
        
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
