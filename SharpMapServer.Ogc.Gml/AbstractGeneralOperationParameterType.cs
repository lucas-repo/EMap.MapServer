namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralOperationParameterType : DefinitionType {
        
        private string minimumOccursField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string minimumOccurs {
            get {
                return this.minimumOccursField;
            }
            set {
                this.minimumOccursField = value;
            }
        }
    }
}
