using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("PT_FreeText", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class PT_FreeText_Type : AbstractObject_Type {
        
        private LocalisedCharacterString_PropertyType[] textGroupField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("textGroup")]
        public LocalisedCharacterString_PropertyType[] textGroup {
            get {
                return this.textGroupField;
            }
            set {
                this.textGroupField = value;
            }
        }
    }
}
