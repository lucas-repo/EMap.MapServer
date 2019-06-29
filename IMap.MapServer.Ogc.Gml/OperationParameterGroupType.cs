namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("OperationParameterGroup", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OperationParameterGroupType : OperationParameterGroupBaseType {
        
        private IdentifierType[] groupIDField;
        
        private StringOrRefType remarksField;
        
        private string maximumOccursField;
        
        private AbstractGeneralOperationParameterRefType[] includesParameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groupID")]
        public IdentifierType[] groupID {
            get {
                return this.groupIDField;
            }
            set {
                this.groupIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string maximumOccurs {
            get {
                return this.maximumOccursField;
            }
            set {
                this.maximumOccursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesParameter")]
        public AbstractGeneralOperationParameterRefType[] includesParameter {
            get {
                return this.includesParameterField;
            }
            set {
                this.includesParameterField = value;
            }
        }
    }
}
