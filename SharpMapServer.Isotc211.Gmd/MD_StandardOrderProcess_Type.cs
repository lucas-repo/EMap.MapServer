using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_StandardOrderProcess", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_StandardOrderProcess_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType feesField;
        
        private DateTime_PropertyType plannedAvailableDateTimeField;
        
        private CharacterString_PropertyType orderingInstructionsField;
        
        private CharacterString_PropertyType turnaroundField;
        
        
        public CharacterString_PropertyType fees {
            get {
                return this.feesField;
            }
            set {
                this.feesField = value;
            }
        }
        
        
        public DateTime_PropertyType plannedAvailableDateTime {
            get {
                return this.plannedAvailableDateTimeField;
            }
            set {
                this.plannedAvailableDateTimeField = value;
            }
        }
        
        
        public CharacterString_PropertyType orderingInstructions {
            get {
                return this.orderingInstructionsField;
            }
            set {
                this.orderingInstructionsField = value;
            }
        }
        
        
        public CharacterString_PropertyType turnaround {
            get {
                return this.turnaroundField;
            }
            set {
                this.turnaroundField = value;
            }
        }
    }
}
