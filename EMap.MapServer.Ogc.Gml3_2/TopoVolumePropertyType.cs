namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("topoVolumeProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoVolumePropertyType {
        
        private TopoVolumeType topoVolumeField;
        
        private bool ownsField;
        
        public TopoVolumePropertyType() {
            this.ownsField = false;
        }
        
        
        public TopoVolumeType TopoVolume {
            get {
                return this.topoVolumeField;
            }
            set {
                this.topoVolumeField = value;
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
