namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiGeometryProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiGeometryPropertyType {
        
        private AbstractGeometricAggregateType _GeometricAggregateField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractGeometricAggregateType _GeometricAggregate {
            get {
                return this._GeometricAggregateField;
            }
            set {
                this._GeometricAggregateField = value;
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
