using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_ExtendedElementInformation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_ExtendedElementInformation_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType nameField;
        
        private CharacterString_PropertyType shortNameField;
        
        private Integer_PropertyType domainCodeField;
        
        private CharacterString_PropertyType definitionField;
        
        private MD_ObligationCode_PropertyType obligationField;
        
        private CharacterString_PropertyType conditionField;
        
        private MD_DatatypeCode_PropertyType dataTypeField;
        
        private CharacterString_PropertyType maximumOccurrenceField;
        
        private CharacterString_PropertyType domainValueField;
        
        private CharacterString_PropertyType[] parentEntityField;
        
        private CharacterString_PropertyType ruleField;
        
        private CharacterString_PropertyType[] rationaleField;
        
        private CI_ResponsibleParty_PropertyType[] sourceField;
        
        
        public CharacterString_PropertyType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public CharacterString_PropertyType shortName {
            get {
                return this.shortNameField;
            }
            set {
                this.shortNameField = value;
            }
        }
        
        
        public Integer_PropertyType domainCode {
            get {
                return this.domainCodeField;
            }
            set {
                this.domainCodeField = value;
            }
        }
        
        
        public CharacterString_PropertyType definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
        
        
        public MD_ObligationCode_PropertyType obligation {
            get {
                return this.obligationField;
            }
            set {
                this.obligationField = value;
            }
        }
        
        
        public CharacterString_PropertyType condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
        
        
        public MD_DatatypeCode_PropertyType dataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        
        public CharacterString_PropertyType maximumOccurrence {
            get {
                return this.maximumOccurrenceField;
            }
            set {
                this.maximumOccurrenceField = value;
            }
        }
        
        
        public CharacterString_PropertyType domainValue {
            get {
                return this.domainValueField;
            }
            set {
                this.domainValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("parentEntity")]
        public CharacterString_PropertyType[] parentEntity {
            get {
                return this.parentEntityField;
            }
            set {
                this.parentEntityField = value;
            }
        }
        
        
        public CharacterString_PropertyType rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("rationale")]
        public CharacterString_PropertyType[] rationale {
            get {
                return this.rationaleField;
            }
            set {
                this.rationaleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public CI_ResponsibleParty_PropertyType[] source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
}
