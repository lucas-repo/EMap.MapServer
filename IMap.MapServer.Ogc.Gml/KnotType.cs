namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class KnotType {
        
        private double valueField;
        
        private string multiplicityField;
        
        private double weightField;
        
        /// <remarks/>
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string multiplicity {
            get {
                return this.multiplicityField;
            }
            set {
                this.multiplicityField = value;
            }
        }
        
        /// <remarks/>
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
