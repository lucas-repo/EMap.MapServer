namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_PortrayalCatalogueReference_PropertyType {
        
        private MD_PortrayalCatalogueReference_Type mD_PortrayalCatalogueReferenceField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public MD_PortrayalCatalogueReference_Type MD_PortrayalCatalogueReference {
            get {
                return this.mD_PortrayalCatalogueReferenceField;
            }
            set {
                this.mD_PortrayalCatalogueReferenceField = value;
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
