namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("topoPointProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoPointPropertyType {
        
        private TopoPointType topoPointField;
        
        private bool ownsField;
        
        public TopoPointPropertyType() {
            this.ownsField = false;
        }
        
        
        public TopoPointType TopoPoint {
            get {
                return this.topoPointField;
            }
            set {
                this.topoPointField = value;
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
