using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_ScopeDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_ScopeDescription_Type {
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("attributeInstances", typeof(ObjectReference_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(ObjectReference_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("dataset", typeof(CharacterString_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("featureInstances", typeof(ObjectReference_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("features", typeof(ObjectReference_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("other", typeof(CharacterString_PropertyType))]
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
