using SharpMapServer.Ogc.Ows1_1;

namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Element", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ElementType {
        
        private MetadataType metadataField;
        
        private ValueListType valueListField;
        
        private string nameField;
        
        private System.Xml.XmlQualifiedName typeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        public ValueListType ValueList {
            get {
                return this.valueListField;
            }
            set {
                this.valueListField = value;
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
