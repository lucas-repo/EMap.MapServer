namespace EMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("MultiplicityRange", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
    public partial class MultiplicityRange_Type : AbstractObject_Type {
        
        private Integer_PropertyType lowerField;
        
        private UnlimitedInteger_PropertyType upperField;
        
        
        public Integer_PropertyType lower {
            get {
                return this.lowerField;
            }
            set {
                this.lowerField = value;
            }
        }
        
        
        public UnlimitedInteger_PropertyType upper {
            get {
                return this.upperField;
            }
            set {
                this.upperField = value;
            }
        }
    }
}
