namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Solid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SolidType : AbstractSolidType {
        
        private SurfacePropertyType exteriorField;
        
        private SurfacePropertyType[] interiorField;
        
        /// <remarks/>
        public SurfacePropertyType exterior {
            get {
                return this.exteriorField;
            }
            set {
                this.exteriorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public SurfacePropertyType[] interior {
            get {
                return this.interiorField;
            }
            set {
                this.interiorField = value;
            }
        }
    }
}
