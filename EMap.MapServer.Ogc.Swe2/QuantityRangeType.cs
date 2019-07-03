namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("QuantityRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class QuantityRangeType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedValuesPropertyType constraintField;
        
        private string valueField;
        
        
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
