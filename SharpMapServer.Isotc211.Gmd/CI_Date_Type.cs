using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Date", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class CI_Date_Type : AbstractObject_Type {
        
        private Date_PropertyType dateField;
        
        private CI_DateTypeCode_PropertyType dateTypeField;
        
        
        public Date_PropertyType date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        
        public CI_DateTypeCode_PropertyType dateType {
            get {
                return this.dateTypeField;
            }
            set {
                this.dateTypeField = value;
            }
        }
    }
}
