namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class ContactInformation {
        
        private ContactPersonPrimary contactPersonPrimaryField;
        
        private string contactPositionField;
        
        private ContactAddress contactAddressField;
        
        private string contactVoiceTelephoneField;
        
        private string contactFacsimileTelephoneField;
        
        private string contactElectronicMailAddressField;
        
        
        public ContactPersonPrimary ContactPersonPrimary {
            get {
                return this.contactPersonPrimaryField;
            }
            set {
                this.contactPersonPrimaryField = value;
            }
        }
        
        
        public string ContactPosition {
            get {
                return this.contactPositionField;
            }
            set {
                this.contactPositionField = value;
            }
        }
        
        
        public ContactAddress ContactAddress {
            get {
                return this.contactAddressField;
            }
            set {
                this.contactAddressField = value;
            }
        }
        
        
        public string ContactVoiceTelephone {
            get {
                return this.contactVoiceTelephoneField;
            }
            set {
                this.contactVoiceTelephoneField = value;
            }
        }
        
        
        public string ContactFacsimileTelephone {
            get {
                return this.contactFacsimileTelephoneField;
            }
            set {
                this.contactFacsimileTelephoneField = value;
            }
        }
        
        
        public string ContactElectronicMailAddress {
            get {
                return this.contactElectronicMailAddressField;
            }
            set {
                this.contactElectronicMailAddressField = value;
            }
        }
    }
}
