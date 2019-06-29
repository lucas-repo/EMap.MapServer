namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Face", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class FaceType : AbstractTopoPrimitiveType {
        
        private DirectedEdgePropertyType[] directedEdgeField;
        
        private DirectedTopoSolidPropertyType[] directedTopoSolidField;
        
        private SurfacePropertyType surfacePropertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge {
            get {
                return this.directedEdgeField;
            }
            set {
                this.directedEdgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid {
            get {
                return this.directedTopoSolidField;
            }
            set {
                this.directedTopoSolidField = value;
            }
        }
        
        /// <remarks/>
        public SurfacePropertyType surfaceProperty {
            get {
                return this.surfacePropertyField;
            }
            set {
                this.surfacePropertyField = value;
            }
        }
    }
}
