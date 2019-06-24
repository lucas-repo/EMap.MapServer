namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("pointMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class PointArrayPropertyType {
        
        private PointType[] pointField;
        
        private bool ownsField;
        
        public PointArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public PointType[] Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
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
