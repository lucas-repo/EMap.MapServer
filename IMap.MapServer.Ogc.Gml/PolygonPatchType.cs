namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("PolygonPatch", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PolygonPatchType : AbstractSurfacePatchType {
        
        private AbstractRingPropertyType exteriorField;
        
        private AbstractRingPropertyType[] interiorField;
        
        private SurfaceInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        public PolygonPatchType() {
            this.interpolationField = SurfaceInterpolationType.planar;
        }
        
        /// <remarks/>
        public AbstractRingPropertyType exterior {
            get {
                return this.exteriorField;
            }
            set {
                this.exteriorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public AbstractRingPropertyType[] interior {
            get {
                return this.interiorField;
            }
            set {
                this.interiorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified {
            get {
                return this.interpolationFieldSpecified;
            }
            set {
                this.interpolationFieldSpecified = value;
            }
        }
    }
}
