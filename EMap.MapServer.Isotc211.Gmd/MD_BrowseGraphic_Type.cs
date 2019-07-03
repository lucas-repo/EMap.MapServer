using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_BrowseGraphic", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_BrowseGraphic_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType fileNameField;
        
        private CharacterString_PropertyType fileDescriptionField;
        
        private CharacterString_PropertyType fileTypeField;
        
        
        public CharacterString_PropertyType fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        
        public CharacterString_PropertyType fileDescription {
            get {
                return this.fileDescriptionField;
            }
            set {
                this.fileDescriptionField = value;
            }
        }
        
        
        public CharacterString_PropertyType fileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }
    }
}
