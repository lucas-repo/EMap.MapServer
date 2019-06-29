namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Quantity", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class QuantityType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedValuesPropertyType constraintField;
        
        private double valueField;
        
        private bool valueFieldSpecified;
        
        
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
}
