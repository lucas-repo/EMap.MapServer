using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Medium", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Medium_Type : AbstractObject_Type {
        
        private MD_MediumNameCode_PropertyType nameField;
        
        private Real_PropertyType[] densityField;
        
        private CharacterString_PropertyType densityUnitsField;
        
        private Integer_PropertyType volumesField;
        
        private MD_MediumFormatCode_PropertyType[] mediumFormatField;
        
        private CharacterString_PropertyType mediumNoteField;
        
        
        public MD_MediumNameCode_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("density")]
        public Real_PropertyType[] density {
            get {
                return this.densityField;
            }
            set {
                this.densityField = value;
            }
        }
        
        
        public CharacterString_PropertyType densityUnits {
            get {
                return this.densityUnitsField;
            }
            set {
                this.densityUnitsField = value;
            }
        }
        
        
        public Integer_PropertyType volumes {
            get {
                return this.volumesField;
            }
            set {
                this.volumesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("mediumFormat")]
        public MD_MediumFormatCode_PropertyType[] mediumFormat {
            get {
                return this.mediumFormatField;
            }
            set {
                this.mediumFormatField = value;
            }
        }
        
        
        public CharacterString_PropertyType mediumNote {
            get {
                return this.mediumNoteField;
            }
            set {
                this.mediumNoteField = value;
            }
        }
    }
}
