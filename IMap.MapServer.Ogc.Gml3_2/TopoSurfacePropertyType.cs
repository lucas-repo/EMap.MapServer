namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("topoSurfaceProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoSurfacePropertyType {
        
        private TopoSurfaceType topoSurfaceField;
        
        private bool ownsField;
        
        public TopoSurfacePropertyType() {
            this.ownsField = false;
        }
        
        
        public TopoSurfaceType TopoSurface {
            get {
                return this.topoSurfaceField;
            }
            set {
                this.topoSurfaceField = value;
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
