namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("target", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TargetPropertyType {
        
        private AbstractGMLType itemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Feature", typeof(AbstractFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
        public AbstractGMLType Item {
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
