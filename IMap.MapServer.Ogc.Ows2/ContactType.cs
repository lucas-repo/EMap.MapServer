namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ContactInfo", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ContactType {
        
        private TelephoneType phoneField;
        
        private AddressType addressField;
        
        private OnlineResourceType onlineResourceField;
        
        private string hoursOfServiceField;
        
        private string contactInstructionsField;
        
        
        public TelephoneType Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        
        public AddressType Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        
        public OnlineResourceType OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
        
        
        public string HoursOfService {
            get {
                return this.hoursOfServiceField;
            }
            set {
                this.hoursOfServiceField = value;
            }
        }
        
        
        public string ContactInstructions {
            get {
                return this.contactInstructionsField;
            }
            set {
                this.contactInstructionsField = value;
            }
        }
    }
}
