namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("usesSingleOperation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SingleOperationRefType {
        
        private AbstractCoordinateOperationType _SingleOperationField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractCoordinateOperationType _SingleOperation {
            get {
                return this._SingleOperationField;
            }
            set {
                this._SingleOperationField = value;
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
