namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class QualityPropertyType {
        
        private QuantityType quantityField;
        
        private QuantityRangeType quantityRangeField;
        
        private CategoryType categoryField;
        
        private TextType textField;
        
        
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        
        public QuantityRangeType QuantityRange {
            get {
                return this.quantityRangeField;
            }
            set {
                this.quantityRangeField = value;
            }
        }
        
        
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        
        public TextType Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
}
