using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class AvailableFunctionType {
        
        private MetadataType metadataField;
        
        private System.Xml.XmlQualifiedName returnsField;
        
        private ArgumentType[] argumentsField;
        
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
        
        
        public System.Xml.XmlQualifiedName Returns {
            get {
                return this.returnsField;
            }
            set {
                this.returnsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable=false)]
        public ArgumentType[] Arguments {
            get {
                return this.argumentsField;
            }
            set {
                this.argumentsField = value;
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
