namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class EX_TemporalExtent_PropertyType {
        
        private EX_TemporalExtent_Type eX_TemporalExtentField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public EX_TemporalExtent_Type EX_TemporalExtent {
            get {
                return this.eX_TemporalExtentField;
            }
            set {
                this.eX_TemporalExtentField = value;
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
