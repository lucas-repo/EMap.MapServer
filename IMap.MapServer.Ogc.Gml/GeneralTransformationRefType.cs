namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("generalTransformationRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeneralTransformationRefType {
        
        private AbstractGeneralTransformationType _GeneralTransformationField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractGeneralTransformationType _GeneralTransformation {
            get {
                return this._GeneralTransformationField;
            }
            set {
                this._GeneralTransformationField = value;
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
