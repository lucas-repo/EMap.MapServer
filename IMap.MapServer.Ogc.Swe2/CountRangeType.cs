namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CountRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CountRangeType : AbstractSimpleComponentType {
        
        private AllowedValuesPropertyType constraintField;
        
        private string valueField;
        
        
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
