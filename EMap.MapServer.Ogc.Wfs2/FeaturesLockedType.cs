using EMap.MapServer.Ogc.Fes2;

namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class FeaturesLockedType {
        
        private ResourceIdType[] resourceIdField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("ResourceId", Namespace="http://www.opengis.net/fes/2.0")]
        public ResourceIdType[] ResourceId {
            get {
                return this.resourceIdField;
            }
            set {
                this.resourceIdField = value;
            }
        }
    }
}
