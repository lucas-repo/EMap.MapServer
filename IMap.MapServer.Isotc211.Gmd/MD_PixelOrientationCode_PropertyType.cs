namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_PixelOrientationCode_PropertyType {
        
        private MD_PixelOrientationCode_Type mD_PixelOrientationCodeField;
        
        private string nilReasonField;
        
        
        public MD_PixelOrientationCode_Type MD_PixelOrientationCode {
            get {
                return this.mD_PixelOrientationCodeField;
            }
            set {
                this.mD_PixelOrientationCodeField = value;
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
