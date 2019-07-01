using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DQ_ConformanceResult", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DQ_ConformanceResult_Type : AbstractDQ_Result_Type {
        
        private CI_Citation_PropertyType specificationField;
        
        private CharacterString_PropertyType explanationField;
        
        private Boolean_PropertyType passField;
        
        
        public CI_Citation_PropertyType specification {
            get {
                return this.specificationField;
            }
            set {
                this.specificationField = value;
            }
        }
        
        
        public CharacterString_PropertyType explanation {
            get {
                return this.explanationField;
            }
            set {
                this.explanationField = value;
            }
        }
        
        
        public Boolean_PropertyType pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
            }
        }
    }
}
