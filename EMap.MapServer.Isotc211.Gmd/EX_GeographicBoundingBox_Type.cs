using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_GeographicBoundingBox", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_GeographicBoundingBox_Type : AbstractEX_GeographicExtent_Type {
        
        private Decimal_PropertyType westBoundLongitudeField;
        
        private Decimal_PropertyType eastBoundLongitudeField;
        
        private Decimal_PropertyType southBoundLatitudeField;
        
        private Decimal_PropertyType northBoundLatitudeField;
        
        
        public Decimal_PropertyType westBoundLongitude {
            get {
                return this.westBoundLongitudeField;
            }
            set {
                this.westBoundLongitudeField = value;
            }
        }
        
        
        public Decimal_PropertyType eastBoundLongitude {
            get {
                return this.eastBoundLongitudeField;
            }
            set {
                this.eastBoundLongitudeField = value;
            }
        }
        
        
        public Decimal_PropertyType southBoundLatitude {
            get {
                return this.southBoundLatitudeField;
            }
            set {
                this.southBoundLatitudeField = value;
            }
        }
        
        
        public Decimal_PropertyType northBoundLatitude {
            get {
                return this.northBoundLatitudeField;
            }
            set {
                this.northBoundLatitudeField = value;
            }
        }
    }
}
