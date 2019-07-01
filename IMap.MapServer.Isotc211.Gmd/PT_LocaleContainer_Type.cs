using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("PT_LocaleContainer", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class PT_LocaleContainer_Type {
        
        private CharacterString_PropertyType descriptionField;
        
        private PT_Locale_PropertyType localeField;
        
        private CI_Date_PropertyType[] dateField;
        
        private CI_ResponsibleParty_PropertyType[] responsiblePartyField;
        
        private LocalisedCharacterString_PropertyType[] localisedStringField;
        
        
        public CharacterString_PropertyType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        public PT_Locale_PropertyType locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("date")]
        public CI_Date_PropertyType[] date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("responsibleParty")]
        public CI_ResponsibleParty_PropertyType[] responsibleParty {
            get {
                return this.responsiblePartyField;
            }
            set {
                this.responsiblePartyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("localisedString")]
        public LocalisedCharacterString_PropertyType[] localisedString {
            get {
                return this.localisedStringField;
            }
            set {
                this.localisedStringField = value;
            }
        }
    }
}
