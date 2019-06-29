namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("isolated", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class IsolatedPropertyType {
        
        private AbstractTopoPrimitiveType itemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Edge", typeof(EdgeType))]
        [System.Xml.Serialization.XmlElementAttribute("Node", typeof(NodeType))]
        public AbstractTopoPrimitiveType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
