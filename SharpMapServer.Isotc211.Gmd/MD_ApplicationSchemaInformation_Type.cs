using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_ApplicationSchemaInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_ApplicationSchemaInformation_Type : AbstractObject_Type {
        
        private CI_Citation_PropertyType nameField;
        
        private CharacterString_PropertyType schemaLanguageField;
        
        private CharacterString_PropertyType constraintLanguageField;
        
        private CharacterString_PropertyType schemaAsciiField;
        
        private Binary_PropertyType graphicsFileField;
        
        private Binary_PropertyType softwareDevelopmentFileField;
        
        private CharacterString_PropertyType softwareDevelopmentFileFormatField;
        
        
        public CI_Citation_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public CharacterString_PropertyType schemaLanguage {
            get {
                return this.schemaLanguageField;
            }
            set {
                this.schemaLanguageField = value;
            }
        }
        
        
        public CharacterString_PropertyType constraintLanguage {
            get {
                return this.constraintLanguageField;
            }
            set {
                this.constraintLanguageField = value;
            }
        }
        
        
        public CharacterString_PropertyType schemaAscii {
            get {
                return this.schemaAsciiField;
            }
            set {
                this.schemaAsciiField = value;
            }
        }
        
        
        public Binary_PropertyType graphicsFile {
            get {
                return this.graphicsFileField;
            }
            set {
                this.graphicsFileField = value;
            }
        }
        
        
        public Binary_PropertyType softwareDevelopmentFile {
            get {
                return this.softwareDevelopmentFileField;
            }
            set {
                this.softwareDevelopmentFileField = value;
            }
        }
        
        
        public CharacterString_PropertyType softwareDevelopmentFileFormat {
            get {
                return this.softwareDevelopmentFileFormatField;
            }
            set {
                this.softwareDevelopmentFileFormatField = value;
            }
        }
    }
}
