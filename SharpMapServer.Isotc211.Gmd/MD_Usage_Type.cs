using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Usage", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Usage_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType specificUsageField;
        
        private DateTime_PropertyType usageDateTimeField;
        
        private CharacterString_PropertyType userDeterminedLimitationsField;
        
        private CI_ResponsibleParty_PropertyType[] userContactInfoField;
        
        
        public CharacterString_PropertyType specificUsage {
            get {
                return this.specificUsageField;
            }
            set {
                this.specificUsageField = value;
            }
        }
        
        
        public DateTime_PropertyType usageDateTime {
            get {
                return this.usageDateTimeField;
            }
            set {
                this.usageDateTimeField = value;
            }
        }
        
        
        public CharacterString_PropertyType userDeterminedLimitations {
            get {
                return this.userDeterminedLimitationsField;
            }
            set {
                this.userDeterminedLimitationsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("userContactInfo")]
        public CI_ResponsibleParty_PropertyType[] userContactInfo {
            get {
                return this.userContactInfoField;
            }
            set {
                this.userContactInfoField = value;
            }
        }
    }
}
