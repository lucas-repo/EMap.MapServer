namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeographicCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GeographicCRSType : AbstractCRSType {
        
        private EllipsoidalCSPropertyType usesEllipsoidalCSField;
        
        private GeodeticDatumPropertyType usesGeodeticDatumField;
        
        
        public EllipsoidalCSPropertyType usesEllipsoidalCS {
            get {
                return this.usesEllipsoidalCSField;
            }
            set {
                this.usesEllipsoidalCSField = value;
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
