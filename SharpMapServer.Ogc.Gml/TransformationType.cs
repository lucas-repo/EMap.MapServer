namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Transformation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TransformationType : AbstractGeneralTransformationType {
        
        private OperationMethodRefType usesMethodField;
        
        private ParameterValueType[] usesValueField;
        
        /// <remarks/>
        public OperationMethodRefType usesMethod {
            get {
                return this.usesMethodField;
            }
            set {
                this.usesMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesValue")]
        public ParameterValueType[] usesValue {
            get {
                return this.usesValueField;
            }
            set {
                this.usesValueField = value;
            }
        }
    }
}
