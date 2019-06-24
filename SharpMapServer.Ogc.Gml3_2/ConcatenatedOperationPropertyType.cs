namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("concatenatedOperationRef", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ConcatenatedOperationPropertyType {
        
        private ConcatenatedOperationType concatenatedOperationField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        public ConcatenatedOperationType ConcatenatedOperation {
            get {
                return this.concatenatedOperationField;
            }
            set {
                this.concatenatedOperationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
