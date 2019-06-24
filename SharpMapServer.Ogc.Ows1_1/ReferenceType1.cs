namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReferenceType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ReferenceType", Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class ReferenceType1 : AbstractReferenceBaseType {
        
        private CodeType identifierField;
        
        private LanguageStringType[] abstractField;
        
        private string formatField;
        
        private MetadataType[] metadataField;
        
        
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public LanguageStringType[] Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
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
    }
}
