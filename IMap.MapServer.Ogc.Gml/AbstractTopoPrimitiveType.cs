namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopoSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTopoPrimitiveType : AbstractTopologyType {
        
        private IsolatedPropertyType[] isolatedField;
        
        private ContainerPropertyType containerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isolated")]
        public IsolatedPropertyType[] isolated {
            get {
                return this.isolatedField;
            }
            set {
                this.isolatedField = value;
            }
        }
        
        /// <remarks/>
        public ContainerPropertyType container {
            get {
                return this.containerField;
            }
            set {
                this.containerField = value;
            }
        }
    }
}
