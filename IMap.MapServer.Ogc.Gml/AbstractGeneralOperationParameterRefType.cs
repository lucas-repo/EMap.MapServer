namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesParameter", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class AbstractGeneralOperationParameterRefType {
        
        private AbstractGeneralOperationParameterType _GeneralOperationParameterField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractGeneralOperationParameterType _GeneralOperationParameter {
            get {
                return this._GeneralOperationParameterField;
            }
            set {
                this._GeneralOperationParameterField = value;
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
