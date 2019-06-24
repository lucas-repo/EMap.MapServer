namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Node", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class NodeType : AbstractTopoPrimitiveType {
        
        private DirectedEdgePropertyType[] directedEdgeField;
        
        private PointPropertyType pointPropertyField;
        
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
        public PointPropertyType pointProperty {
            get {
                return this.pointPropertyField;
            }
            set {
                this.pointPropertyField = value;
            }
        }
    }
}
