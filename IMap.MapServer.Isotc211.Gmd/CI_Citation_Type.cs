using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Citation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Citation_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType titleField;
        
        private CharacterString_PropertyType[] alternateTitleField;
        
        private CI_Date_PropertyType[] dateField;
        
        private CharacterString_PropertyType editionField;
        
        private Date_PropertyType editionDateField;
        
        private MD_Identifier_PropertyType[] identifierField;
        
        private CI_ResponsibleParty_PropertyType[] citedResponsiblePartyField;
        
        private CI_PresentationFormCode_PropertyType[] presentationFormField;
        
        private CI_Series_PropertyType seriesField;
        
        private CharacterString_PropertyType otherCitationDetailsField;
        
        private CharacterString_PropertyType collectiveTitleField;
        
        private CharacterString_PropertyType iSBNField;
        
        private CharacterString_PropertyType iSSNField;
        
        
        public CharacterString_PropertyType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("alternateTitle")]
        public CharacterString_PropertyType[] alternateTitle {
            get {
                return this.alternateTitleField;
            }
            set {
                this.alternateTitleField = value;
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
        
        
        public CharacterString_PropertyType edition {
            get {
                return this.editionField;
            }
            set {
                this.editionField = value;
            }
        }
        
        
        public Date_PropertyType editionDate {
            get {
                return this.editionDateField;
            }
            set {
                this.editionDateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public MD_Identifier_PropertyType[] identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("citedResponsibleParty")]
        public CI_ResponsibleParty_PropertyType[] citedResponsibleParty {
            get {
                return this.citedResponsiblePartyField;
            }
            set {
                this.citedResponsiblePartyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("presentationForm")]
        public CI_PresentationFormCode_PropertyType[] presentationForm {
            get {
                return this.presentationFormField;
            }
            set {
                this.presentationFormField = value;
            }
        }
        
        
        public CI_Series_PropertyType series {
            get {
                return this.seriesField;
            }
            set {
                this.seriesField = value;
            }
        }
        
        
        public CharacterString_PropertyType otherCitationDetails {
            get {
                return this.otherCitationDetailsField;
            }
            set {
                this.otherCitationDetailsField = value;
            }
        }
        
        
        public CharacterString_PropertyType collectiveTitle {
            get {
                return this.collectiveTitleField;
            }
            set {
                this.collectiveTitleField = value;
            }
        }
        
        
        public CharacterString_PropertyType ISBN {
            get {
                return this.iSBNField;
            }
            set {
                this.iSBNField = value;
            }
        }
        
        
        public CharacterString_PropertyType ISSN {
            get {
                return this.iSSNField;
            }
            set {
                this.iSSNField = value;
            }
        }
    }
}
