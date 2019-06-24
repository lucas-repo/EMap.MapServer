namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GeodeticDatumType : AbstractDatumType {
        
        private PrimeMeridianPropertyType primeMeridianField;
        
        private EllipsoidPropertyType ellipsoidField;
        
        
        public PrimeMeridianPropertyType primeMeridian {
            get {
                return this.primeMeridianField;
            }
            set {
                this.primeMeridianField = value;
            }
        }
        
        
        public EllipsoidPropertyType ellipsoid {
            get {
                return this.ellipsoidField;
            }
            set {
                this.ellipsoidField = value;
            }
        }
    }
}
