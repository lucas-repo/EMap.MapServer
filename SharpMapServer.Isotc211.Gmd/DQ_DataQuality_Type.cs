using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DQ_DataQuality", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DQ_DataQuality_Type : AbstractObject_Type {
        
        private DQ_Scope_PropertyType scopeField;
        
        private DQ_Element_PropertyType[] reportField;
        
        private LI_Lineage_PropertyType lineageField;
        
        
        public DQ_Scope_PropertyType scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("report")]
        public DQ_Element_PropertyType[] report {
            get {
                return this.reportField;
            }
            set {
                this.reportField = value;
            }
        }
        
        
        public LI_Lineage_PropertyType lineage {
            get {
                return this.lineageField;
            }
            set {
                this.lineageField = value;
            }
        }
    }
}
