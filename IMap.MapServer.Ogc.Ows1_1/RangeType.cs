namespace EMap.MapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Range", Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class RangeType {
        
        private ValueType minimumValueField;
        
        private ValueType maximumValueField;
        
        private ValueType spacingField;
        
        private RangeTypeRangeClosure rangeClosureField;
        
        private bool rangeClosureFieldSpecified;
        
        public RangeType() {
            this.rangeClosureField = RangeTypeRangeClosure.closed;
        }
        
        
        public ValueType MinimumValue {
            get {
                return this.minimumValueField;
            }
            set {
                this.minimumValueField = value;
            }
        }
        
        
        public ValueType MaximumValue {
            get {
                return this.maximumValueField;
            }
            set {
                this.maximumValueField = value;
            }
        }
        
        
        public ValueType Spacing {
            get {
                return this.spacingField;
            }
            set {
                this.spacingField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        [System.ComponentModel.DefaultValueAttribute(RangeTypeRangeClosure.closed)]
        public RangeTypeRangeClosure rangeClosure {
            get {
                return this.rangeClosureField;
            }
            set {
                this.rangeClosureField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rangeClosureSpecified {
            get {
                return this.rangeClosureFieldSpecified;
            }
            set {
                this.rangeClosureFieldSpecified = value;
            }
        }
    }
}
