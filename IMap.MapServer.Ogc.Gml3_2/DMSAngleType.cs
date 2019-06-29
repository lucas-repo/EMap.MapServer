namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("dmsAngleValue", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DMSAngleType {
        
        private DegreesType degreesField;
        
        private object[] itemsField;
        
        private ItemsChoiceType12[] itemsElementNameField;
        
        
        public DegreesType degrees {
            get {
                return this.degreesField;
            }
            set {
                this.degreesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("decimalMinutes", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("minutes", typeof(string), DataType="nonNegativeInteger")]
        [System.Xml.Serialization.XmlElementAttribute("seconds", typeof(decimal))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType12[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
