namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class TimeTopologyPrimitivePropertyType {
        
        private AbstractTimeTopologyPrimitiveType _TimeTopologyPrimitiveField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractTimeTopologyPrimitiveType _TimeTopologyPrimitive {
            get {
                return this._TimeTopologyPrimitiveField;
            }
            set {
                this._TimeTopologyPrimitiveField = value;
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
