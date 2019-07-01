namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("OperationMethod", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class OperationMethodType : IdentifiedObjectType {
        
        private object itemField;
        
        private string sourceDimensionsField;
        
        private string targetDimensionsField;
        
        private AbstractGeneralOperationParameterPropertyType[] parameterField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("formula", typeof(CodeType))]
        [System.Xml.Serialization.XmlElementAttribute("formulaCitation", typeof(formulaCitation))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string sourceDimensions {
            get {
                return this.sourceDimensionsField;
            }
            set {
                this.sourceDimensionsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string targetDimensions {
            get {
                return this.targetDimensionsField;
            }
            set {
                this.targetDimensionsField = value;
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
