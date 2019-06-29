namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ParameterValue", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ParameterValueType : AbstractGeneralParameterValueType {
        
        private object itemField;
        
        private ItemChoiceType3 itemElementNameField;
        
        private OperationParameterPropertyType operationParameterField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("booleanValue", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("dmsAngleValue", typeof(DMSAngleType))]
        [System.Xml.Serialization.XmlElementAttribute("integerValue", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("integerValueList", typeof(string), DataType="integer")]
        [System.Xml.Serialization.XmlElementAttribute("stringValue", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("valueFile", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("valueList", typeof(MeasureListType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        
        public OperationParameterPropertyType operationParameter {
            get {
                return this.operationParameterField;
            }
            set {
                this.operationParameterField = value;
            }
        }
    }
}
