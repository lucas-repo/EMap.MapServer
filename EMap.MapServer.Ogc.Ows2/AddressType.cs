namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    public partial class AddressType {
        
        private string[] deliveryPointField;
        
        private string cityField;
        
        private string administrativeAreaField;
        
        private string postalCodeField;
        
        private string countryField;
        
        private string[] electronicMailAddressField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPoint")]
        public string[] DeliveryPoint {
            get {
                return this.deliveryPointField;
            }
            set {
                this.deliveryPointField = value;
            }
        }
        
        
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        
        public string AdministrativeArea {
            get {
                return this.administrativeAreaField;
            }
            set {
                this.administrativeAreaField = value;
            }
        }
        
        
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ElectronicMailAddress")]
        public string[] ElectronicMailAddress {
            get {
                return this.electronicMailAddressField;
            }
            set {
                this.electronicMailAddressField = value;
            }
        }
    }
}
