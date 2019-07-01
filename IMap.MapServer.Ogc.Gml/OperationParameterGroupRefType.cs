namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valuesOfGroup", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OperationParameterGroupRefType {
        
        private OperationParameterGroupType operationParameterGroupField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public OperationParameterGroupType OperationParameterGroup {
            get {
                return this.operationParameterGroupField;
            }
            set {
                this.operationParameterGroupField = value;
            }
        }
        
        /// <remarks/>
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
