using IMap.MapServer.Ogc.Gml3_2;
using System.Xml.Linq;

namespace IMap.MapServer.Ogc.Gmlcov {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ParameterValueType", Namespace="http://www.opengis.net/gmlcov/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("ParameterValue", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class ParameterValueType1 : AbstractGeneralParameterValueType {
        
        private object itemField;
        
        private ItemChoiceType4 itemElementNameField;
        
        private OperationParameterPropertyType operationParameterField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("booleanValue", typeof(bool), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("dmsAngleValue", typeof(DMSAngleType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("integerValue", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("integerValueList", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="integer")]
        [System.Xml.Serialization.XmlElementAttribute("stringValue", typeof(string), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("value", typeof(MeasureType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("valueFile", typeof(string), Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("valueList", typeof(MeasureListType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("geometryValue", typeof(GeometryPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("vectorValue", typeof(VectorType))]
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
        public ItemChoiceType4 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
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
