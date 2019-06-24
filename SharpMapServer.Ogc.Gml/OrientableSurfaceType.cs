namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OrientableSurface", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OrientableSurfaceType : AbstractSurfaceType {
        
        private SurfacePropertyType baseSurfaceField;
        
        private SignType orientationField;
        
        public OrientableSurfaceType() {
            this.orientationField = SignType.Item1;
        }
        
        /// <remarks/>
        public SurfacePropertyType baseSurface {
            get {
                return this.baseSurfaceField;
            }
            set {
                this.baseSurfaceField = value;
            }
        }
        
        /// <remarks/>
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
