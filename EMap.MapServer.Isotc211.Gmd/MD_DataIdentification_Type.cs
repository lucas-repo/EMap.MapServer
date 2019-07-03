using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_DataIdentification", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_DataIdentification_Type : AbstractMD_Identification_Type {
        
        private MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationTypeField;
        
        private MD_Resolution_PropertyType[] spatialResolutionField;
        
        private CharacterString_PropertyType[] languageField;
        
        private MD_CharacterSetCode_PropertyType[] characterSetField;
        
        private MD_TopicCategoryCode_PropertyType[] topicCategoryField;
        
        private CharacterString_PropertyType environmentDescriptionField;
        
        private EX_Extent_PropertyType[] extentField;
        
        private CharacterString_PropertyType supplementalInformationField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("spatialRepresentationType")]
        public MD_SpatialRepresentationTypeCode_PropertyType[] spatialRepresentationType {
            get {
                return this.spatialRepresentationTypeField;
            }
            set {
                this.spatialRepresentationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("spatialResolution")]
        public MD_Resolution_PropertyType[] spatialResolution {
            get {
                return this.spatialResolutionField;
            }
            set {
                this.spatialResolutionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("language")]
        public CharacterString_PropertyType[] language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("characterSet")]
        public MD_CharacterSetCode_PropertyType[] characterSet {
            get {
                return this.characterSetField;
            }
            set {
                this.characterSetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("topicCategory")]
        public MD_TopicCategoryCode_PropertyType[] topicCategory {
            get {
                return this.topicCategoryField;
            }
            set {
                this.topicCategoryField = value;
            }
        }
        
        
        public CharacterString_PropertyType environmentDescription {
            get {
                return this.environmentDescriptionField;
            }
            set {
                this.environmentDescriptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("extent")]
        public EX_Extent_PropertyType[] extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
        
        
        public CharacterString_PropertyType supplementalInformation {
            get {
                return this.supplementalInformationField;
            }
            set {
                this.supplementalInformationField = value;
            }
        }
    }
}
