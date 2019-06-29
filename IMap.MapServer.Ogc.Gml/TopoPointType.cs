namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoPoint", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoPointType : AbstractTopologyType {
        
        private DirectedNodePropertyType directedNodeField;
        
        /// <remarks/>
        public DirectedNodePropertyType directedNode {
            get {
                return this.directedNodeField;
            }
            set {
                this.directedNodeField = value;
            }
        }
    }
}
