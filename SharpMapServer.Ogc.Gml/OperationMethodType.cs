namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationMethod", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OperationMethodType : OperationMethodBaseType {
        
        private IdentifierType[] methodIDField;
        
        private StringOrRefType remarksField;
        
        private CodeType1 methodFormulaField;
        
        private string sourceDimensionsField;
        
        private string targetDimensionsField;
        
        private AbstractGeneralOperationParameterRefType[] usesParameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("methodID")]
        public IdentifierType[] methodID {
            get {
                return this.methodIDField;
            }
            set {
                this.methodIDField = value;
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
        
        /// <remarks/>
        public CodeType1 methodFormula {
            get {
                return this.methodFormulaField;
            }
            set {
                this.methodFormulaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string sourceDimensions {
            get {
                return this.sourceDimensionsField;
            }
            set {
                this.sourceDimensionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string targetDimensions {
            get {
                return this.targetDimensionsField;
            }
            set {
                this.targetDimensionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesParameter")]
        public AbstractGeneralOperationParameterRefType[] usesParameter {
            get {
                return this.usesParameterField;
            }
            set {
                this.usesParameterField = value;
            }
        }
    }
}
