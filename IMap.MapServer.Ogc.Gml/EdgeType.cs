namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Edge", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EdgeType : AbstractTopoPrimitiveType {
        
        private DirectedNodePropertyType[] directedNodeField;
        
        private DirectedFacePropertyType[] directedFaceField;
        
        private CurvePropertyType curvePropertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedNode")]
        public DirectedNodePropertyType[] directedNode {
            get {
                return this.directedNodeField;
            }
            set {
                this.directedNodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace {
            get {
                return this.directedFaceField;
            }
            set {
                this.directedFaceField = value;
            }
        }
        
        /// <remarks/>
        public CurvePropertyType curveProperty {
            get {
                return this.curvePropertyField;
            }
            set {
                this.curvePropertyField = value;
            }
        }
    }
}
