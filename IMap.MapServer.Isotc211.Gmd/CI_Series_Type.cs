using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Series", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Series_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType nameField;
        
        private CharacterString_PropertyType issueIdentificationField;
        
        private CharacterString_PropertyType pageField;
        
        
        public CharacterString_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public CharacterString_PropertyType issueIdentification {
            get {
                return this.issueIdentificationField;
            }
            set {
                this.issueIdentificationField = value;
            }
        }
        
        
        public CharacterString_PropertyType page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
    }
}
