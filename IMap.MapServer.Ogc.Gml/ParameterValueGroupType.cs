namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("parameterValueGroup", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ParameterValueGroupType : AbstractGeneralParameterValueType {
        
        private AbstractGeneralParameterValueType[] includesValueField;
        
        private OperationParameterGroupRefType valuesOfGroupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesValue")]
        public AbstractGeneralParameterValueType[] includesValue {
            get {
                return this.includesValueField;
            }
            set {
                this.includesValueField = value;
            }
        }
        
        /// <remarks/>
        public OperationParameterGroupRefType valuesOfGroup {
            get {
                return this.valuesOfGroupField;
            }
            set {
                this.valuesOfGroupField = value;
            }
        }
    }
}
