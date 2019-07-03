namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Count", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CountType : AbstractSimpleComponentType {
        
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
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
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
