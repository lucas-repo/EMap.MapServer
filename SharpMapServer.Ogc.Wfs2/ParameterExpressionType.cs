using SharpMapServer.Ogc.Ows1_1;

namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class ParameterExpressionType {
        
        private Title[] titleField;
        
        private Abstract[] abstractField;
        
        private MetadataType[] metadataField;
        
        private string nameField;
        
        private System.Xml.XmlQualifiedName typeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace="http://www.opengis.net/ows/1.1")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
