namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeocentricCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GeocentricCRSType : AbstractCRSType {
        
        private object itemField;
        
        private GeodeticDatumPropertyType usesGeodeticDatumField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof(CartesianCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("usesSphericalCS", typeof(SphericalCSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public GeodeticDatumPropertyType usesGeodeticDatum {
            get {
                return this.usesGeodeticDatumField;
            }
            set {
                this.usesGeodeticDatumField = value;
            }
        }
    }
}
