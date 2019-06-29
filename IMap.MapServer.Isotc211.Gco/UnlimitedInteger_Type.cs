namespace IMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("UnlimitedInteger", Namespace="http://www.isotc211.org/2005/gco", IsNullable=true)]
    public partial class UnlimitedInteger_Type {
        
        private bool isInfiniteField;
        
        private bool isInfiniteFieldSpecified;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isInfinite {
            get {
                return this.isInfiniteField;
            }
            set {
                this.isInfiniteField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInfiniteSpecified {
            get {
                return this.isInfiniteFieldSpecified;
            }
            set {
                this.isInfiniteFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="nonNegativeInteger")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
