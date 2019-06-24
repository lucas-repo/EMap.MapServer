namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public abstract partial class AbstractSimpleComponentType : AbstractDataComponentType {
        
        private QualityPropertyType[] qualityField;
        
        private NilValuesPropertyType nilValuesField;
        
        private string referenceFrameField;
        
        private string axisIDField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("quality")]
        public QualityPropertyType[] quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
            }
        }
        
        
        public NilValuesPropertyType nilValues {
            get {
                return this.nilValuesField;
            }
            set {
                this.nilValuesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string axisID {
            get {
                return this.axisIDField;
            }
            set {
                this.axisIDField = value;
            }
        }
    }
}
