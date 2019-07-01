using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_ResponsibleParty", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_ResponsibleParty_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType individualNameField;
        
        private CharacterString_PropertyType organisationNameField;
        
        private CharacterString_PropertyType positionNameField;
        
        private CI_Contact_PropertyType contactInfoField;
        
        private CI_RoleCode_PropertyType roleField;
        
        
        public CharacterString_PropertyType individualName {
            get {
                return this.individualNameField;
            }
            set {
                this.individualNameField = value;
            }
        }
        
        
        public CharacterString_PropertyType organisationName {
            get {
                return this.organisationNameField;
            }
            set {
                this.organisationNameField = value;
            }
        }
        
        
        public CharacterString_PropertyType positionName {
            get {
                return this.positionNameField;
            }
            set {
                this.positionNameField = value;
            }
        }
        
        
        public CI_Contact_PropertyType contactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
            }
        }
        
        
        public CI_RoleCode_PropertyType role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
    }
}
