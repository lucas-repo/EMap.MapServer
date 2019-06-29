using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class ResourceIdentifierType {
        
        private MetadataType metadataField;
        
        private System.Xml.XmlQualifiedName nameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
