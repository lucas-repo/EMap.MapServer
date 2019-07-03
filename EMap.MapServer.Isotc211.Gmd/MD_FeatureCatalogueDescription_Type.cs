using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_FeatureCatalogueDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type {
        
        private Boolean_PropertyType complianceCodeField;
        
        private CharacterString_PropertyType[] languageField;
        
        private Boolean_PropertyType includedWithDatasetField;
        
        private GenericName_PropertyType[] featureTypesField;
        
        private CI_Citation_PropertyType[] featureCatalogueCitationField;
        
        
        public Boolean_PropertyType complianceCode {
            get {
                return this.complianceCodeField;
            }
            set {
                this.complianceCodeField = value;
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
        
        
        public Boolean_PropertyType includedWithDataset {
            get {
                return this.includedWithDatasetField;
            }
            set {
                this.includedWithDatasetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("featureTypes")]
        public GenericName_PropertyType[] featureTypes {
            get {
                return this.featureTypesField;
            }
            set {
                this.featureTypesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("featureCatalogueCitation")]
        public CI_Citation_PropertyType[] featureCatalogueCitation {
            get {
                return this.featureCatalogueCitationField;
            }
            set {
                this.featureCatalogueCitationField = value;
            }
        }
    }
}
