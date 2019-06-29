using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="GetCapabilitiesType", Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class GetCapabilitiesType : Ows1_1.GetCapabilitiesType {
        
        private string serviceField;
        
        public GetCapabilitiesType() {
            this.serviceField = "WFS";
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
