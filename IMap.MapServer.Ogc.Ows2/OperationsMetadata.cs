namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class OperationsMetadata {
        
        private Operation[] operationField;
        
        private DomainType[] parameterField;
        
        private DomainType[] constraintField;
        
        private object extendedCapabilitiesField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public Operation[] Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
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
        
        
        public object ExtendedCapabilities {
            get {
                return this.extendedCapabilitiesField;
            }
            set {
                this.extendedCapabilitiesField = value;
            }
        }
    }
}
