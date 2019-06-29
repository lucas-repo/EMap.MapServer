namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_TopicCategoryCode_PropertyType {
        
        private MD_TopicCategoryCode_Type mD_TopicCategoryCodeField;
        
        private string nilReasonField;
        
        
        public MD_TopicCategoryCode_Type MD_TopicCategoryCode {
            get {
                return this.mD_TopicCategoryCodeField;
            }
            set {
                this.mD_TopicCategoryCodeField = value;
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
