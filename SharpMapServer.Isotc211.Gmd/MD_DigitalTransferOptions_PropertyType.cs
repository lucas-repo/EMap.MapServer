namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_DigitalTransferOptions_PropertyType {
        
        private MD_DigitalTransferOptions_Type mD_DigitalTransferOptionsField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public MD_DigitalTransferOptions_Type MD_DigitalTransferOptions {
            get {
                return this.mD_DigitalTransferOptionsField;
            }
            set {
                this.mD_DigitalTransferOptionsField = value;
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
