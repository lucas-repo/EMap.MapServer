using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("RS_Identifier", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class RS_Identifier_Type : MD_Identifier_Type {
        
        private CharacterString_PropertyType codeSpaceField;
        
        private CharacterString_PropertyType versionField;
        
        
        public CharacterString_PropertyType codeSpace {
            get {
                return this.codeSpaceField;
            }
            set {
                this.codeSpaceField = value;
            }
        }
        
        
        public CharacterString_PropertyType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
