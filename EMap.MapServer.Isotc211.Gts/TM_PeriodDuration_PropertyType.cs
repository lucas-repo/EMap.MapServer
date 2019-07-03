namespace EMap.MapServer.Isotc211.Gts {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gts")]
    public partial class TM_PeriodDuration_PropertyType {
        
        private string tM_PeriodDurationField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string TM_PeriodDuration {
            get {
                return this.tM_PeriodDurationField;
            }
            set {
                this.tM_PeriodDurationField = value;
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
