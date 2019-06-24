using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Distribution", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Distribution_Type : AbstractObject_Type {
        
        private MD_Format_PropertyType[] distributionFormatField;
        
        private MD_Distributor_PropertyType[] distributorField;
        
        private MD_DigitalTransferOptions_PropertyType[] transferOptionsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("distributionFormat")]
        public MD_Format_PropertyType[] distributionFormat {
            get {
                return this.distributionFormatField;
            }
            set {
                this.distributionFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("distributor")]
        public MD_Distributor_PropertyType[] distributor {
            get {
                return this.distributorField;
            }
            set {
                this.distributorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("transferOptions")]
        public MD_DigitalTransferOptions_PropertyType[] transferOptions {
            get {
                return this.transferOptionsField;
            }
            set {
                this.transferOptionsField = value;
            }
        }
    }
}
