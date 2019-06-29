using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("LI_Lineage", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class LI_Lineage_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType statementField;
        
        private LI_ProcessStep_PropertyType[] processStepField;
        
        private LI_Source_PropertyType[] sourceField;
        
        
        public CharacterString_PropertyType statement {
            get {
                return this.statementField;
            }
            set {
                this.statementField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("processStep")]
        public LI_ProcessStep_PropertyType[] processStep {
            get {
                return this.processStepField;
            }
            set {
                this.processStepField = value;
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
