using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_MetadataExtensionInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_MetadataExtensionInformation_Type : AbstractObject_Type {
        
        private CI_OnlineResource_PropertyType extensionOnLineResourceField;
        
        private MD_ExtendedElementInformation_PropertyType[] extendedElementInformationField;
        
        
        public CI_OnlineResource_PropertyType extensionOnLineResource {
            get {
                return this.extensionOnLineResourceField;
            }
            set {
                this.extensionOnLineResourceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("extendedElementInformation")]
        public MD_ExtendedElementInformation_PropertyType[] extendedElementInformation {
            get {
                return this.extendedElementInformationField;
            }
            set {
                this.extendedElementInformationField = value;
            }
        }
    }
}
