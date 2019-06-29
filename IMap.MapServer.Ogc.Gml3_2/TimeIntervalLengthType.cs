namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("timeInterval", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeIntervalLengthType {
        
        private string unitField;
        
        private string radixField;
        
        private string factorField;
        
        private decimal valueField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string radix {
            get {
                return this.radixField;
            }
            set {
                this.radixField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string factor {
            get {
                return this.factorField;
            }
            set {
                this.factorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
