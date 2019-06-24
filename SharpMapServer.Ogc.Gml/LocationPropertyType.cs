namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("location", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class LocationPropertyType {
        
        private object itemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationKeyWord", typeof(CodeType1))]
        [System.Xml.Serialization.XmlElementAttribute("LocationString", typeof(StringOrRefType))]
        [System.Xml.Serialization.XmlElementAttribute("Null", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
        public object Item {
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
