using SharpMapServer.Ogc.Ows2;

namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Capabilities", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CapabilitiesType : CapabilitiesBaseType {
        
        private ServiceMetadataType serviceMetadataField;
        
        private ContentsType contentsField;
        
        
        public ServiceMetadataType ServiceMetadata {
            get {
                return this.serviceMetadataField;
            }
            set {
                this.serviceMetadataField = value;
            }
        }
        
        
        public ContentsType Contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
            }
        }
    }
}
