using System.Xml.Linq;

namespace SharpMapServer.Ogc {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class ServiceExceptionReport {
        
        private ServiceExceptionType[] serviceExceptionField;
        
        private string versionField;
        
        public ServiceExceptionReport() {
            this.versionField = "1.3.0";
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ServiceException")]
        public ServiceExceptionType[] ServiceException {
            get {
                return this.serviceExceptionField;
            }
            set {
                this.serviceExceptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
