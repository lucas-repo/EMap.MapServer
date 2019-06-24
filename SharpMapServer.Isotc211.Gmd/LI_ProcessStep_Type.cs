using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("LI_ProcessStep", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class LI_ProcessStep_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType descriptionField;
        
        private CharacterString_PropertyType rationaleField;
        
        private DateTime_PropertyType dateTimeField;
        
        private CI_ResponsibleParty_PropertyType[] processorField;
        
        private LI_Source_PropertyType[] sourceField;
        
        
        public CharacterString_PropertyType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        public CharacterString_PropertyType rationale {
            get {
                return this.rationaleField;
            }
            set {
                this.rationaleField = value;
            }
        }
        
        
        public DateTime_PropertyType dateTime {
            get {
                return this.dateTimeField;
            }
            set {
                this.dateTimeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("processor")]
        public CI_ResponsibleParty_PropertyType[] processor {
            get {
                return this.processorField;
            }
            set {
                this.processorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public LI_Source_PropertyType[] source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
}
