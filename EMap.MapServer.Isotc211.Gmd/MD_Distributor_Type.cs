using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Distributor", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Distributor_Type : AbstractObject_Type {
        
        private CI_ResponsibleParty_PropertyType distributorContactField;
        
        private MD_StandardOrderProcess_PropertyType[] distributionOrderProcessField;
        
        private MD_Format_PropertyType[] distributorFormatField;
        
        private MD_DigitalTransferOptions_PropertyType[] distributorTransferOptionsField;
        
        
        public CI_ResponsibleParty_PropertyType distributorContact {
            get {
                return this.distributorContactField;
            }
            set {
                this.distributorContactField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("distributionOrderProcess")]
        public MD_StandardOrderProcess_PropertyType[] distributionOrderProcess {
            get {
                return this.distributionOrderProcessField;
            }
            set {
                this.distributionOrderProcessField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("distributorFormat")]
        public MD_Format_PropertyType[] distributorFormat {
            get {
                return this.distributorFormatField;
            }
            set {
                this.distributorFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("distributorTransferOptions")]
        public MD_DigitalTransferOptions_PropertyType[] distributorTransferOptions {
            get {
                return this.distributorTransferOptionsField;
            }
            set {
                this.distributorTransferOptionsField = value;
            }
        }
    }
}
