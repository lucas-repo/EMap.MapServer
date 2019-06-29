namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("degrees", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DegreesType {
        
        private DegreesTypeDirection directionField;
        
        private bool directionFieldSpecified;
        
        private string valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DegreesTypeDirection direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
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
