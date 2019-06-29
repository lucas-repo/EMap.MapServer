namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Polygon", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PolygonType : AbstractSurfaceType {
        
        private AbstractRingPropertyType exteriorField;
        
        private AbstractRingPropertyType[] interiorField;
        
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
    }
}
