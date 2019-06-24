namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class HTTP {
        
        private RequestMethodType[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Get", typeof(RequestMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Post", typeof(RequestMethodType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public RequestMethodType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
}
