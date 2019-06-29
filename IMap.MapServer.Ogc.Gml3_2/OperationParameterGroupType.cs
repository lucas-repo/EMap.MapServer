namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("OperationParameterGroup", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class OperationParameterGroupType : AbstractGeneralOperationParameterType {
        
        private string maximumOccursField;
        
        private AbstractGeneralOperationParameterPropertyType[] parameterField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string maximumOccurs {
            get {
                return this.maximumOccursField;
            }
            set {
                this.maximumOccursField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public AbstractGeneralOperationParameterPropertyType[] parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
}
