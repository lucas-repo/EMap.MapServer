namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class Operation {
        
        private DCP[] dCPField;
        
        private DomainType[] parameterField;
        
        private DomainType[] constraintField;
        
        private MetadataType[] metadataField;
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("DCP")]
        public DCP[] DCP {
            get {
                return this.dCPField;
            }
            set {
                this.dCPField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public DomainType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
