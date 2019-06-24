namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractSWEIdentifiableType : AbstractSWEType {
        
        private string identifierField;
        
        private string labelField;
        
        private string descriptionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
}
