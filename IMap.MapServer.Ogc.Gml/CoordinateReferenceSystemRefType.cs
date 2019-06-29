namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateReferenceSystemRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CoordinateReferenceSystemRefType {
        
        private AbstractReferenceSystemType _CoordinateReferenceSystemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractReferenceSystemType _CoordinateReferenceSystem {
            get {
                return this._CoordinateReferenceSystemField;
            }
            set {
                this._CoordinateReferenceSystemField = value;
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
