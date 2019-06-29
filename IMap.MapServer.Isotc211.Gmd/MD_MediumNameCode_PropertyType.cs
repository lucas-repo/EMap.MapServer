using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_MediumNameCode_PropertyType {
        
        private CodeListValue_Type mD_MediumNameCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type MD_MediumNameCode {
            get {
                return this.mD_MediumNameCodeField;
            }
            set {
                this.mD_MediumNameCodeField = value;
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
