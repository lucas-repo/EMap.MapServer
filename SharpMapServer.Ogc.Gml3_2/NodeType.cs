namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Node", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class NodeType : AbstractTopoPrimitiveType {
        
        private FaceOrTopoSolidPropertyType containerField;
        
        private DirectedEdgePropertyType[] directedEdgeField;
        
        private PointPropertyType pointPropertyField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        public FaceOrTopoSolidPropertyType container {
            get {
                return this.containerField;
            }
            set {
                this.containerField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge {
            get {
                return this.directedEdgeField;
            }
            set {
                this.directedEdgeField = value;
            }
        }
        
        
        public PointPropertyType pointProperty {
            get {
                return this.pointPropertyField;
            }
            set {
                this.pointPropertyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
