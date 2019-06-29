using IMap.MapServer.Ogc.Fes2;
using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("WFS_Capabilities", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class WFS_CapabilitiesType : CapabilitiesBaseType {
        
        private WFS_CapabilitiesTypeWSDL wSDLField;
        
        private FeatureTypeType[] featureTypeListField;
        
        private Filter_Capabilities filter_CapabilitiesField;
        
        
        public WFS_CapabilitiesTypeWSDL WSDL {
            get {
                return this.wSDLField;
            }
            set {
                this.wSDLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("FeatureType", IsNullable=false)]
        public FeatureTypeType[] FeatureTypeList {
            get {
                return this.featureTypeListField;
            }
            set {
                this.featureTypeListField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/fes/2.0")]
        public Filter_Capabilities Filter_Capabilities {
            get {
                return this.filter_CapabilitiesField;
            }
            set {
                this.filter_CapabilitiesField = value;
            }
        }
    }
}
