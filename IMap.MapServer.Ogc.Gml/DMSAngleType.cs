namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("dmsAngle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DMSAngleType {
        
        private DegreesType degreesField;
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        /// <remarks/>
        public DegreesType degrees {
            get {
                return this.degreesField;
            }
            set {
                this.degreesField = value;
            }
        }
        
        /// <remarks/>
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
