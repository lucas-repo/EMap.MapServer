namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TopoPrimitiveArrayAssociationType {
        
        private AbstractTopoPrimitiveType[] abstractTopoPrimitiveField;
        
        private bool ownsField;
        
        public TopoPrimitiveArrayAssociationType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractTopoPrimitive")]
        public AbstractTopoPrimitiveType[] AbstractTopoPrimitive {
            get {
                return this.abstractTopoPrimitiveField;
            }
            set {
                this.abstractTopoPrimitiveField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
            }
        }
    }
}
