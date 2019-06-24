using SharpMapServer.Ogc.Ows1_1;

namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class ArgumentType {
        
        private MetadataType metadataField;
        
        private System.Xml.XmlQualifiedName typeField;
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        public System.Xml.XmlQualifiedName Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
