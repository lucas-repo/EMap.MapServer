namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeNode", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeNodeType : AbstractTimeTopologyPrimitiveType {
        
        private TimeEdgePropertyType[] previousEdgeField;
        
        private TimeEdgePropertyType[] nextEdgeField;
        
        private TimeInstantPropertyType positionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("previousEdge")]
        public TimeEdgePropertyType[] previousEdge {
            get {
                return this.previousEdgeField;
            }
            set {
                this.previousEdgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextEdge")]
        public TimeEdgePropertyType[] nextEdge {
            get {
                return this.nextEdgeField;
            }
            set {
                this.nextEdgeField = value;
            }
        }
        
        /// <remarks/>
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
