namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataExtensionInformation_PropertyType {
        
        private MD_MetadataExtensionInformation_Type mD_MetadataExtensionInformationField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public MD_MetadataExtensionInformation_Type MD_MetadataExtensionInformation {
            get {
                return this.mD_MetadataExtensionInformationField;
            }
            set {
                this.mD_MetadataExtensionInformationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuidref {
            get {
                return this.uuidrefField;
            }
            set {
                this.uuidrefField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.isotc211.org/2005/gco")]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
