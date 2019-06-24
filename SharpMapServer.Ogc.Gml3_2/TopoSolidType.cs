namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TopoSolid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoSolidType : AbstractTopoPrimitiveType {
        
        private NodeOrEdgePropertyType[] isolatedField;
        
        private DirectedFacePropertyType[] directedFaceField;
        
        private SolidPropertyType solidPropertyField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        private bool universalField;
        
        public TopoSolidType() {
            this.universalField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("isolated")]
        public NodeOrEdgePropertyType[] isolated {
            get {
                return this.isolatedField;
            }
            set {
                this.isolatedField = value;
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
        
        
        public SolidPropertyType solidProperty {
            get {
                return this.solidPropertyField;
            }
            set {
                this.solidPropertyField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool universal {
            get {
                return this.universalField;
            }
            set {
                this.universalField = value;
            }
        }
    }
}
