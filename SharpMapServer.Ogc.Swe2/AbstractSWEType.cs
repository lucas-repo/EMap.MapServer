namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSWEIdentifiableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractSWEType {
        
        private object[] extensionField;
        
        private string idField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public object[] extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
