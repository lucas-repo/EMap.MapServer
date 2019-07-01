namespace EMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class ContactAddress {
        
        private string addressTypeField;
        
        private string addressField;
        
        private string cityField;
        
        private string stateOrProvinceField;
        
        private string postCodeField;
        
        private string countryField;
        
        
        public string AddressType {
            get {
                return this.addressTypeField;
            }
            set {
                this.addressTypeField = value;
            }
        }
        
        
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
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
        
        
        public string StateOrProvince {
            get {
                return this.stateOrProvinceField;
            }
            set {
                this.stateOrProvinceField = value;
            }
        }
        
        
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
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
    }
}
