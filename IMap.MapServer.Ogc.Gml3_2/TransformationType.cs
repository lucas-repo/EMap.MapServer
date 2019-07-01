namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Transformation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TransformationType : AbstractGeneralTransformationType {
        
        private OperationMethodPropertyType methodField;
        
        private AbstractGeneralParameterValuePropertyType[] parameterValueField;
        
        
        public OperationMethodPropertyType method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("parameterValue")]
        public AbstractGeneralParameterValuePropertyType[] parameterValue {
            get {
                return this.parameterValueField;
            }
            set {
                this.parameterValueField = value;
            }
        }
    }
}
