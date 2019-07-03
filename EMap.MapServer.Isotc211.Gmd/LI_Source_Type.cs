using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("LI_Source", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class LI_Source_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType descriptionField;
        
        private MD_RepresentativeFraction_PropertyType scaleDenominatorField;
        
        private MD_ReferenceSystem_PropertyType sourceReferenceSystemField;
        
        private CI_Citation_PropertyType sourceCitationField;
        
        private EX_Extent_PropertyType[] sourceExtentField;
        
        private LI_ProcessStep_PropertyType[] sourceStepField;
        
        
        public CharacterString_PropertyType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        public MD_RepresentativeFraction_PropertyType scaleDenominator {
            get {
                return this.scaleDenominatorField;
            }
            set {
                this.scaleDenominatorField = value;
            }
        }
        
        
        public MD_ReferenceSystem_PropertyType sourceReferenceSystem {
            get {
                return this.sourceReferenceSystemField;
            }
            set {
                this.sourceReferenceSystemField = value;
            }
        }
        
        
        public CI_Citation_PropertyType sourceCitation {
            get {
                return this.sourceCitationField;
            }
            set {
                this.sourceCitationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("sourceExtent")]
        public EX_Extent_PropertyType[] sourceExtent {
            get {
                return this.sourceExtentField;
            }
            set {
                this.sourceExtentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("sourceStep")]
        public LI_ProcessStep_PropertyType[] sourceStep {
            get {
                return this.sourceStepField;
            }
            set {
                this.sourceStepField = value;
            }
        }
    }
}
