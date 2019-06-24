namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationParameter", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OperationParameterType : OperationParameterBaseType {
        
        private IdentifierType[] parameterIDField;
        
        private StringOrRefType remarksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameterID")]
        public IdentifierType[] parameterID {
            get {
                return this.parameterIDField;
            }
            set {
                this.parameterIDField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
    }
}
