using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_SecurityConstraints_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_LegalConstraints_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Constraints", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Constraints_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType[] useLimitationField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("useLimitation")]
        public CharacterString_PropertyType[] useLimitation {
            get {
                return this.useLimitationField;
            }
            set {
                this.useLimitationField = value;
            }
        }
    }
}
