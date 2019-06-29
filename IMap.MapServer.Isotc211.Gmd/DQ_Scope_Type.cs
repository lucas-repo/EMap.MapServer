using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("DQ_Scope", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class DQ_Scope_Type : AbstractObject_Type {
        
        private MD_ScopeCode_PropertyType levelField;
        
        private EX_Extent_PropertyType extentField;
        
        private MD_ScopeDescription_PropertyType[] levelDescriptionField;
        
        
        public MD_ScopeCode_PropertyType level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        
        public EX_Extent_PropertyType extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("levelDescription")]
        public MD_ScopeDescription_PropertyType[] levelDescription {
            get {
                return this.levelDescriptionField;
            }
            set {
                this.levelDescriptionField = value;
            }
        }
    }
}
