using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ServiceIdentification_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_DataIdentification_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public abstract partial class AbstractMD_Identification_Type : AbstractObject_Type {
        
        private CI_Citation_PropertyType citationField;
        
        private CharacterString_PropertyType abstractField;
        
        private CharacterString_PropertyType purposeField;
        
        private CharacterString_PropertyType[] creditField;
        
        private MD_ProgressCode_PropertyType[] statusField;
        
        private CI_ResponsibleParty_PropertyType[] pointOfContactField;
        
        private MD_MaintenanceInformation_PropertyType[] resourceMaintenanceField;
        
        private MD_BrowseGraphic_PropertyType[] graphicOverviewField;
        
        private MD_Format_PropertyType[] resourceFormatField;
        
        private MD_Keywords_PropertyType[] descriptiveKeywordsField;
        
        private MD_Usage_PropertyType[] resourceSpecificUsageField;
        
        private MD_Constraints_PropertyType[] resourceConstraintsField;
        
        private MD_AggregateInformation_PropertyType[] aggregationInfoField;
        
        
        public CI_Citation_PropertyType citation {
            get {
                return this.citationField;
            }
            set {
                this.citationField = value;
            }
        }
        
        
        public CharacterString_PropertyType @abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        public CharacterString_PropertyType purpose {
            get {
                return this.purposeField;
            }
            set {
                this.purposeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public CharacterString_PropertyType[] credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public MD_ProgressCode_PropertyType[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("pointOfContact")]
        public CI_ResponsibleParty_PropertyType[] pointOfContact {
            get {
                return this.pointOfContactField;
            }
            set {
                this.pointOfContactField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("resourceMaintenance")]
        public MD_MaintenanceInformation_PropertyType[] resourceMaintenance {
            get {
                return this.resourceMaintenanceField;
            }
            set {
                this.resourceMaintenanceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("graphicOverview")]
        public MD_BrowseGraphic_PropertyType[] graphicOverview {
            get {
                return this.graphicOverviewField;
            }
            set {
                this.graphicOverviewField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("resourceFormat")]
        public MD_Format_PropertyType[] resourceFormat {
            get {
                return this.resourceFormatField;
            }
            set {
                this.resourceFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("descriptiveKeywords")]
        public MD_Keywords_PropertyType[] descriptiveKeywords {
            get {
                return this.descriptiveKeywordsField;
            }
            set {
                this.descriptiveKeywordsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("resourceSpecificUsage")]
        public MD_Usage_PropertyType[] resourceSpecificUsage {
            get {
                return this.resourceSpecificUsageField;
            }
            set {
                this.resourceSpecificUsageField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("resourceConstraints")]
        public MD_Constraints_PropertyType[] resourceConstraints {
            get {
                return this.resourceConstraintsField;
            }
            set {
                this.resourceConstraintsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("aggregationInfo")]
        public MD_AggregateInformation_PropertyType[] aggregationInfo {
            get {
                return this.aggregationInfoField;
            }
            set {
                this.aggregationInfoField = value;
            }
        }
    }
}
