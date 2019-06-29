using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Address", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Address_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType[] deliveryPointField;
        
        private CharacterString_PropertyType cityField;
        
        private CharacterString_PropertyType administrativeAreaField;
        
        private CharacterString_PropertyType postalCodeField;
        
        private CharacterString_PropertyType countryField;
        
        private CharacterString_PropertyType[] electronicMailAddressField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("deliveryPoint")]
        public CharacterString_PropertyType[] deliveryPoint {
            get {
                return this.deliveryPointField;
            }
            set {
                this.deliveryPointField = value;
            }
        }
        
        
        public CharacterString_PropertyType city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        
        public CharacterString_PropertyType administrativeArea {
            get {
                return this.administrativeAreaField;
            }
            set {
                this.administrativeAreaField = value;
            }
        }
        
        
        public CharacterString_PropertyType postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        
        public CharacterString_PropertyType country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("electronicMailAddress")]
        public CharacterString_PropertyType[] electronicMailAddress {
            get {
                return this.electronicMailAddressField;
            }
            set {
                this.electronicMailAddressField = value;
            }
        }
    }
}
