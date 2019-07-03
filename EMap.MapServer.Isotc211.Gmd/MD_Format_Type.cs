using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Format", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Format_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType nameField;
        
        private CharacterString_PropertyType versionField;
        
        private CharacterString_PropertyType amendmentNumberField;
        
        private CharacterString_PropertyType specificationField;
        
        private CharacterString_PropertyType fileDecompressionTechniqueField;
        
        private MD_Distributor_PropertyType[] formatDistributorField;
        
        
        public CharacterString_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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
        
        
        public CharacterString_PropertyType amendmentNumber {
            get {
                return this.amendmentNumberField;
            }
            set {
                this.amendmentNumberField = value;
            }
        }
        
        
        public CharacterString_PropertyType specification {
            get {
                return this.specificationField;
            }
            set {
                this.specificationField = value;
            }
        }
        
        
        public CharacterString_PropertyType fileDecompressionTechnique {
            get {
                return this.fileDecompressionTechniqueField;
            }
            set {
                this.fileDecompressionTechniqueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("formatDistributor")]
        public MD_Distributor_PropertyType[] formatDistributor {
            get {
                return this.formatDistributorField;
            }
            set {
                this.formatDistributorField = value;
            }
        }
    }
}
