namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class EX_GeographicBoundingBox {
        
        private double westBoundLongitudeField;
        
        private double eastBoundLongitudeField;
        
        private double southBoundLatitudeField;
        
        private double northBoundLatitudeField;
        
        
        public double westBoundLongitude {
            get {
                return this.westBoundLongitudeField;
            }
            set {
                this.westBoundLongitudeField = value;
            }
        }
        
        
        public double eastBoundLongitude {
            get {
                return this.eastBoundLongitudeField;
            }
            set {
                this.eastBoundLongitudeField = value;
            }
        }
        
        
        public double southBoundLatitude {
            get {
                return this.southBoundLatitudeField;
            }
            set {
                this.southBoundLatitudeField = value;
            }
        }
        
        
        public double northBoundLatitude {
            get {
                return this.northBoundLatitudeField;
            }
            set {
                this.northBoundLatitudeField = value;
            }
        }
    }
}
