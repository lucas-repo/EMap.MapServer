namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class DirectionVectorType {
        
        private object[] itemsField;
        
        private ItemsChoiceType10[] itemsElementNameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("horizontalAngle", typeof(AngleType))]
        [System.Xml.Serialization.XmlElementAttribute("vector", typeof(VectorType))]
        [System.Xml.Serialization.XmlElementAttribute("verticalAngle", typeof(AngleType))]
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
        public ItemsChoiceType10[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
