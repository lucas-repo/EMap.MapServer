namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class ServiceIdentification : DescriptionType {
        
        private CodeType serviceTypeField;
        
        private string[] serviceTypeVersionField;
        
        private string[] profileField;
        
        private string feesField;
        
        private string[] accessConstraintsField;
        
        
        public CodeType ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceTypeVersion")]
        public string[] ServiceTypeVersion {
            get {
                return this.serviceTypeVersionField;
            }
            set {
                this.serviceTypeVersionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Profile", DataType="anyURI")]
        public string[] Profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        
        
        public string Fees {
            get {
                return this.feesField;
            }
            set {
                this.feesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AccessConstraints")]
        public string[] AccessConstraints {
            get {
                return this.accessConstraintsField;
            }
            set {
                this.accessConstraintsField = value;
            }
        }
    }
}
