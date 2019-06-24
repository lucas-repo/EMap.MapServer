namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WGS84BoundingBoxType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("BoundingBox", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class BoundingBoxType {
        
        private string lowerCornerField;
        
        private string upperCornerField;
        
        private string crsField;
        
        private string dimensionsField;
        
        
        public string LowerCorner {
            get {
                return this.lowerCornerField;
            }
            set {
                this.lowerCornerField = value;
            }
        }
        
        
        public string UpperCorner {
            get {
                return this.upperCornerField;
            }
            set {
                this.upperCornerField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string crs {
            get {
                return this.crsField;
            }
            set {
                this.crsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string dimensions {
            get {
                return this.dimensionsField;
            }
            set {
                this.dimensionsField = value;
            }
        }
    }
}
