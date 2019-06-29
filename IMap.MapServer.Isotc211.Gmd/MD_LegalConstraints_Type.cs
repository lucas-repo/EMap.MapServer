using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_LegalConstraints", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_LegalConstraints_Type : MD_Constraints_Type {
        
        private MD_RestrictionCode_PropertyType[] accessConstraintsField;
        
        private MD_RestrictionCode_PropertyType[] useConstraintsField;
        
        private CharacterString_PropertyType[] otherConstraintsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("accessConstraints")]
        public MD_RestrictionCode_PropertyType[] accessConstraints {
            get {
                return this.accessConstraintsField;
            }
            set {
                this.accessConstraintsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("useConstraints")]
        public MD_RestrictionCode_PropertyType[] useConstraints {
            get {
                return this.useConstraintsField;
            }
            set {
                this.useConstraintsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("otherConstraints")]
        public CharacterString_PropertyType[] otherConstraints {
            get {
                return this.otherConstraintsField;
            }
            set {
                this.otherConstraintsField = value;
            }
        }
    }
}
