using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_DigitalTransferOptions", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_DigitalTransferOptions_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType unitsOfDistributionField;
        
        private Real_PropertyType transferSizeField;
        
        private CI_OnlineResource_PropertyType[] onLineField;
        
        private MD_Medium_PropertyType offLineField;
        
        
        public CharacterString_PropertyType unitsOfDistribution {
            get {
                return this.unitsOfDistributionField;
            }
            set {
                this.unitsOfDistributionField = value;
            }
        }
        
        
        public Real_PropertyType transferSize {
            get {
                return this.transferSizeField;
            }
            set {
                this.transferSizeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("onLine")]
        public CI_OnlineResource_PropertyType[] onLine {
            get {
                return this.onLineField;
            }
            set {
                this.onLineField = value;
            }
        }
        
        
        public MD_Medium_PropertyType offLine {
            get {
                return this.offLineField;
            }
            set {
                this.offLineField = value;
            }
        }
    }
}
