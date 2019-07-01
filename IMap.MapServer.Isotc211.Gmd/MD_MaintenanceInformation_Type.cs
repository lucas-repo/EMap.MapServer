using EMap.MapServer.Isotc211.Gco;
using EMap.MapServer.Isotc211.Gts;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_MaintenanceInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_MaintenanceInformation_Type : AbstractObject_Type {
        
        private MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequencyField;
        
        private Date_PropertyType dateOfNextUpdateField;
        
        private TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequencyField;
        
        private MD_ScopeCode_PropertyType[] updateScopeField;
        
        private MD_ScopeDescription_PropertyType[] updateScopeDescriptionField;
        
        private CharacterString_PropertyType[] maintenanceNoteField;
        
        private CI_ResponsibleParty_PropertyType[] contactField;
        
        
        public MD_MaintenanceFrequencyCode_PropertyType maintenanceAndUpdateFrequency {
            get {
                return this.maintenanceAndUpdateFrequencyField;
            }
            set {
                this.maintenanceAndUpdateFrequencyField = value;
            }
        }
        
        
        public Date_PropertyType dateOfNextUpdate {
            get {
                return this.dateOfNextUpdateField;
            }
            set {
                this.dateOfNextUpdateField = value;
            }
        }
        
        
        public TM_PeriodDuration_PropertyType userDefinedMaintenanceFrequency {
            get {
                return this.userDefinedMaintenanceFrequencyField;
            }
            set {
                this.userDefinedMaintenanceFrequencyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("updateScope")]
        public MD_ScopeCode_PropertyType[] updateScope {
            get {
                return this.updateScopeField;
            }
            set {
                this.updateScopeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("updateScopeDescription")]
        public MD_ScopeDescription_PropertyType[] updateScopeDescription {
            get {
                return this.updateScopeDescriptionField;
            }
            set {
                this.updateScopeDescriptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("maintenanceNote")]
        public CharacterString_PropertyType[] maintenanceNote {
            get {
                return this.maintenanceNoteField;
            }
            set {
                this.maintenanceNoteField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public CI_ResponsibleParty_PropertyType[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
    }
}
