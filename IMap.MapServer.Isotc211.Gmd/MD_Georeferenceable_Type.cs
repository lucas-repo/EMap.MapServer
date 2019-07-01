using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Georeferenceable", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Georeferenceable_Type : MD_GridSpatialRepresentation_Type {
        
        private Boolean_PropertyType controlPointAvailabilityField;
        
        private Boolean_PropertyType orientationParameterAvailabilityField;
        
        private CharacterString_PropertyType orientationParameterDescriptionField;
        
        private Record_PropertyType georeferencedParametersField;
        
        private CI_Citation_PropertyType[] parameterCitationField;
        
        
        public Boolean_PropertyType controlPointAvailability {
            get {
                return this.controlPointAvailabilityField;
            }
            set {
                this.controlPointAvailabilityField = value;
            }
        }
        
        
        public Boolean_PropertyType orientationParameterAvailability {
            get {
                return this.orientationParameterAvailabilityField;
            }
            set {
                this.orientationParameterAvailabilityField = value;
            }
        }
        
        
        public CharacterString_PropertyType orientationParameterDescription {
            get {
                return this.orientationParameterDescriptionField;
            }
            set {
                this.orientationParameterDescriptionField = value;
            }
        }
        
        
        public Record_PropertyType georeferencedParameters {
            get {
                return this.georeferencedParametersField;
            }
            set {
                this.georeferencedParametersField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("parameterCitation")]
        public CI_Citation_PropertyType[] parameterCitation {
            get {
                return this.parameterCitationField;
            }
            set {
                this.parameterCitationField = value;
            }
        }
    }
}
