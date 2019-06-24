namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("geometryMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GeometryArrayPropertyType {
        
        private AbstractGeometryType[] abstractGeometryField;
        
        private bool ownsField;
        
        public GeometryArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractGeometry")]
        public AbstractGeometryType[] AbstractGeometry {
            get {
                return this.abstractGeometryField;
            }
            set {
                this.abstractGeometryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
            }
        }
    }
}
