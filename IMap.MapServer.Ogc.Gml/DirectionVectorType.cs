namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectionVector", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DirectionVectorType {
        
        private object[] itemsField;
        
        private ItemsChoiceType5[] itemsElementNameField;
        
        /// <remarks/>
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
