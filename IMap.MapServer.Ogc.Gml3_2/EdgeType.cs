namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Edge", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class EdgeType : AbstractTopoPrimitiveType {
        
        private TopoSolidPropertyType containerField;
        
        private DirectedNodePropertyType[] directedNodeField;
        
        private DirectedFacePropertyType[] directedFaceField;
        
        private CurvePropertyType curvePropertyField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        public TopoSolidPropertyType container {
            get {
                return this.containerField;
            }
            set {
                this.containerField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("directedNode")]
        public DirectedNodePropertyType[] directedNode {
            get {
                return this.directedNodeField;
            }
            set {
                this.directedNodeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public DirectedFacePropertyType[] directedFace {
            get {
                return this.directedFaceField;
            }
            set {
                this.directedFaceField = value;
            }
        }
        
        
        public CurvePropertyType curveProperty {
            get {
                return this.curvePropertyField;
            }
            set {
                this.curvePropertyField = value;
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
