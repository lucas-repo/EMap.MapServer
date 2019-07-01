namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Face", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class FaceType : AbstractTopoPrimitiveType {
        
        private NodePropertyType[] isolatedField;
        
        private DirectedEdgePropertyType[] directedEdgeField;
        
        private DirectedTopoSolidPropertyType[] directedTopoSolidField;
        
        private SurfacePropertyType surfacePropertyField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        private bool universalField;
        
        public FaceType() {
            this.universalField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("isolated")]
        public NodePropertyType[] isolated {
            get {
                return this.isolatedField;
            }
            set {
                this.isolatedField = value;
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
        
        
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid {
            get {
                return this.directedTopoSolidField;
            }
            set {
                this.directedTopoSolidField = value;
            }
        }
        
        
        public SurfacePropertyType surfaceProperty {
            get {
                return this.surfacePropertyField;
            }
            set {
                this.surfacePropertyField = value;
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
