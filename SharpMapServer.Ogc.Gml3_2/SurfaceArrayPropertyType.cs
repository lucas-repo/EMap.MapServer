namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("surfaceMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SurfaceArrayPropertyType {
        
        private AbstractSurfaceType[] abstractSurfaceField;
        
        private bool ownsField;
        
        public SurfaceArrayPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractSurface")]
        public AbstractSurfaceType[] AbstractSurface {
            get {
                return this.abstractSurfaceField;
            }
            set {
                this.abstractSurfaceField = value;
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
