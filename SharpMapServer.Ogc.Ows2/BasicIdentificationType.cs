namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    public partial class BasicIdentificationType : DescriptionType {
        
        private CodeType1 identifierField;
        
        private MetadataType[] metadataField;
        
        
        public CodeType1 Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
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
