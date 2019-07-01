namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ParameterValueGroup", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ParameterValueGroupType : AbstractGeneralParameterValueType {
        
        private AbstractGeneralParameterValuePropertyType[] parameterValueField;
        
        private OperationParameterGroupPropertyType groupField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("parameterValue")]
        public AbstractGeneralParameterValuePropertyType[] parameterValue {
            get {
                return this.parameterValueField;
            }
            set {
                this.parameterValueField = value;
            }
        }
        
        
        public OperationParameterGroupPropertyType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
}
