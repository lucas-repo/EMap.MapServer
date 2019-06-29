namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMember", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoPrimitiveMemberType {
        
        private AbstractTopoPrimitiveType _TopoPrimitiveField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractTopoPrimitiveType _TopoPrimitive {
            get {
                return this._TopoPrimitiveField;
            }
            set {
                this._TopoPrimitiveField = value;
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
