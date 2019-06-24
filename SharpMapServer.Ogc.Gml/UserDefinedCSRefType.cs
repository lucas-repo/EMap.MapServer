namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("userDefinedCSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class UserDefinedCSRefType {
        
        private UserDefinedCSType userDefinedCSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public UserDefinedCSType UserDefinedCS {
            get {
                return this.userDefinedCSField;
            }
            set {
                this.userDefinedCSField = value;
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
