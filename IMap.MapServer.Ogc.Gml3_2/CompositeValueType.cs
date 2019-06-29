namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeValue", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CompositeValueType : AbstractGMLType {
        
        private ValuePropertyType[] valueComponentField;
        
        private ValueArrayPropertyType valueComponentsField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        [System.Xml.Serialization.XmlElementAttribute("valueComponent")]
        public ValuePropertyType[] valueComponent {
            get {
                return this.valueComponentField;
            }
            set {
                this.valueComponentField = value;
            }
        }
        
        
        public ValueArrayPropertyType valueComponents {
            get {
                return this.valueComponentsField;
            }
            set {
                this.valueComponentsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
