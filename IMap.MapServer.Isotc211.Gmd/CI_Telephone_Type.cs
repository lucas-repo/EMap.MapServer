using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Telephone", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Telephone_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType[] voiceField;
        
        private CharacterString_PropertyType[] facsimileField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("voice")]
        public CharacterString_PropertyType[] voice {
            get {
                return this.voiceField;
            }
            set {
                this.voiceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("facsimile")]
        public CharacterString_PropertyType[] facsimile {
            get {
                return this.facsimileField;
            }
            set {
                this.facsimileField = value;
            }
        }
    }
}
