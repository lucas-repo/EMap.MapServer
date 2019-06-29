namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableSurface", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class OrientableSurfaceType : AbstractSurfaceType {
        
        private SurfacePropertyType baseSurfaceField;
        
        private SignType orientationField;
        
        public OrientableSurfaceType() {
            this.orientationField = SignType.Item1;
        }
        
        
        public SurfacePropertyType baseSurface {
            get {
                return this.baseSurfaceField;
            }
            set {
                this.baseSurfaceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
        public SignType orientation {
            get {
                return this.orientationField;
            }
            set {
                this.orientationField = value;
            }
        }
    }
}
