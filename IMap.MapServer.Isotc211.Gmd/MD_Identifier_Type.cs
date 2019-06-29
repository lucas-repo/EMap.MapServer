using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RS_Identifier_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Identifier", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Identifier_Type : AbstractObject_Type {
        
        private CI_Citation_PropertyType authorityField;
        
        private CharacterString_PropertyType codeField;
        
        
        public CI_Citation_PropertyType authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
            }
        }
        
        
        public CharacterString_PropertyType code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
}
