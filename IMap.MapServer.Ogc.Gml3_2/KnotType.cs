namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class KnotType {
        
        private double valueField;
        
        private string multiplicityField;
        
        private double weightField;
        
        
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string multiplicity {
            get {
                return this.multiplicityField;
            }
            set {
                this.multiplicityField = value;
            }
        }
        
        
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
    }
}
