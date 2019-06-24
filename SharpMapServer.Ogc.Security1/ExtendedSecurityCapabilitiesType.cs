using SharpMapServer.Ogc.Ows1_1;
using System.Xml.Linq;

namespace SharpMapServer.Ogc.Security1
{
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/security/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("ExtendedSecurityCapabilities", Namespace="http://www.opengis.net/security/1.0", IsNullable=false)]
    public partial class ExtendedSecurityCapabilitiesType {
        
        private OperationsMetadata operationsMetadataField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public OperationsMetadata OperationsMetadata {
            get {
                return this.operationsMetadataField;
            }
            set {
                this.operationsMetadataField = value;
            }
        }
    }
}
