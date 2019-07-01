using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("PT_Locale", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class PT_Locale_Type : AbstractObject_Type {
        
        private LanguageCode_PropertyType languageCodeField;
        
        private Country_PropertyType countryField;
        
        private MD_CharacterSetCode_PropertyType characterEncodingField;
        
        
        public LanguageCode_PropertyType languageCode {
            get {
                return this.languageCodeField;
            }
            set {
                this.languageCodeField = value;
            }
        }
        
        
        public Country_PropertyType country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        
        public MD_CharacterSetCode_PropertyType characterEncoding {
            get {
                return this.characterEncodingField;
            }
            set {
                this.characterEncodingField = value;
            }
        }
    }
}
