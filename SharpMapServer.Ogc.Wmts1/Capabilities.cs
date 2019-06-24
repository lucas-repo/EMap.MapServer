using SharpMapServer.Ogc.Ows1_1;
using System.Xml.Serialization;

namespace SharpMapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class Capabilities : CapabilitiesBaseType {
        
        private ContentsType contentsField;
        
        private Themes[] themesField;
        
        private OnlineResourceType[] wSDLField;
        
        private OnlineResourceType[] serviceMetadataURLField;
        
        
        public ContentsType Contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Themes", typeof(Themes))]
        public Themes[] Themes {
            get {
                return this.themesField;
            }
            set {
                this.themesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("WSDL")]
        public OnlineResourceType[] WSDL {
            get {
                return this.wSDLField;
            }
            set {
                this.wSDLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceMetadataURL")]
        public OnlineResourceType[] ServiceMetadataURL {
            get {
                return this.serviceMetadataURLField;
            }
            set {
                this.serviceMetadataURLField = value;
            }
        }
    }
}
