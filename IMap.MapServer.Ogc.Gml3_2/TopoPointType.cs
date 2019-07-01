namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TopoPoint", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoPointType : AbstractTopologyType {
        
        private DirectedNodePropertyType directedNodeField;
        
        
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
