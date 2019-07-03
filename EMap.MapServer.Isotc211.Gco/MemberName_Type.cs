namespace EMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("MemberName", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
    public partial class MemberName_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType aNameField;
        
        private TypeName_PropertyType attributeTypeField;
        
        
        public CharacterString_PropertyType aName {
            get {
                return this.aNameField;
            }
            set {
                this.aNameField = value;
            }
        }
        
        
        public TypeName_PropertyType attributeType {
            get {
                return this.attributeTypeField;
            }
            set {
                this.attributeTypeField = value;
            }
        }
    }
}
