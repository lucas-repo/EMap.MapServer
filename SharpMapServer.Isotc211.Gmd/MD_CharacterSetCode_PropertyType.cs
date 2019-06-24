using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_CharacterSetCode_PropertyType {
        
        private CodeListValue_Type mD_CharacterSetCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type MD_CharacterSetCode {
            get {
                return this.mD_CharacterSetCodeField;
            }
            set {
                this.mD_CharacterSetCodeField = value;
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
