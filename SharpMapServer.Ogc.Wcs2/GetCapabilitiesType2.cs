using SharpMapServer.Ogc.Ows2;

namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="GetCapabilitiesType", Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class GetCapabilitiesType2 : GetCapabilitiesType {
        
        private string serviceField;
        
        public GetCapabilitiesType2() {
            this.serviceField = "WCS";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
    }
}
