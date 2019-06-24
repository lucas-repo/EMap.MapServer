namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeNode", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeNodeType : AbstractTimeTopologyPrimitiveType {
        
        private TimeEdgePropertyType[] previousEdgeField;
        
        private TimeEdgePropertyType[] nextEdgeField;
        
        private TimeInstantPropertyType positionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("previousEdge")]
        public TimeEdgePropertyType[] previousEdge {
            get {
                return this.previousEdgeField;
            }
            set {
                this.previousEdgeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("nextEdge")]
        public TimeEdgePropertyType[] nextEdge {
            get {
                return this.nextEdgeField;
            }
            set {
                this.nextEdgeField = value;
            }
        }
        
        
        public TimeInstantPropertyType position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
    }
}
