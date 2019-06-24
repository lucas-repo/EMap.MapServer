using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class LocalisedCharacterString_PropertyType : ObjectReference_PropertyType {
        
        private LocalisedCharacterString_Type localisedCharacterStringField;
        
        
        public LocalisedCharacterString_Type LocalisedCharacterString {
            get {
                return this.localisedCharacterStringField;
            }
            set {
                this.localisedCharacterStringField = value;
            }
        }
    }
}
