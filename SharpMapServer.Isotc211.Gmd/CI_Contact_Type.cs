using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Contact", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Contact_Type : AbstractObject_Type {
        
        private CI_Telephone_PropertyType phoneField;
        
        private CI_Address_PropertyType addressField;
        
        private CI_OnlineResource_PropertyType onlineResourceField;
        
        private CharacterString_PropertyType hoursOfServiceField;
        
        private CharacterString_PropertyType contactInstructionsField;
        
        
        public CI_Telephone_PropertyType phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        
        public CI_Address_PropertyType address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        
        public CI_OnlineResource_PropertyType onlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
        
        
        public CharacterString_PropertyType hoursOfService {
            get {
                return this.hoursOfServiceField;
            }
            set {
                this.hoursOfServiceField = value;
            }
        }
        
        
        public CharacterString_PropertyType contactInstructions {
            get {
                return this.contactInstructionsField;
            }
            set {
                this.contactInstructionsField = value;
            }
        }
    }
}
