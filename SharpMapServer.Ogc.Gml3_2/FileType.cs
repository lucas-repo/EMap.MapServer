namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("File", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class FileType {
        
        private AssociationRoleType rangeParametersField;
        
        private string itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private CodeType fileStructureField;
        
        private string mimeTypeField;
        
        private string compressionField;
        
        
        public AssociationRoleType rangeParameters {
            get {
                return this.rangeParametersField;
            }
            set {
                this.rangeParametersField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("fileName", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("fileReference", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        
        public CodeType fileStructure {
            get {
                return this.fileStructureField;
            }
            set {
                this.fileStructureField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string mimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string compression {
            get {
                return this.compressionField;
            }
            set {
                this.compressionField = value;
            }
        }
    }
}
