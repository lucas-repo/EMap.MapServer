using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_SecurityConstraints", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_SecurityConstraints_Type : MD_Constraints_Type {
        
        private MD_ClassificationCode_PropertyType classificationField;
        
        private CharacterString_PropertyType userNoteField;
        
        private CharacterString_PropertyType classificationSystemField;
        
        private CharacterString_PropertyType handlingDescriptionField;
        
        
        public MD_ClassificationCode_PropertyType classification {
            get {
                return this.classificationField;
            }
            set {
                this.classificationField = value;
            }
        }
        
        
        public CharacterString_PropertyType userNote {
            get {
                return this.userNoteField;
            }
            set {
                this.userNoteField = value;
            }
        }
        
        
        public CharacterString_PropertyType classificationSystem {
            get {
                return this.classificationSystemField;
            }
            set {
                this.classificationSystemField = value;
            }
        }
        
        
        public CharacterString_PropertyType handlingDescription {
            get {
                return this.handlingDescriptionField;
            }
            set {
                this.handlingDescriptionField = value;
            }
        }
    }
}
