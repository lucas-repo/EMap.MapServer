namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AnyNumericalPropertyType {
        
        private CountType countField;
        
        private QuantityType quantityField;
        
        private TimeType timeField;
        
        
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        
        public TimeType Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
    }
}
