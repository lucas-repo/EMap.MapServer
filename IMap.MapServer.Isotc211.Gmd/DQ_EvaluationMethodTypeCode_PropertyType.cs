using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class DQ_EvaluationMethodTypeCode_PropertyType {
        
        private CodeListValue_Type dQ_EvaluationMethodTypeCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type DQ_EvaluationMethodTypeCode {
            get {
                return this.dQ_EvaluationMethodTypeCodeField;
            }
            set {
                this.dQ_EvaluationMethodTypeCodeField = value;
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
