namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ValuePropertyType {
        
        private bool booleanField;
        
        private CodeType1 categoryField;
        
        private MeasureType quantityField;
        
        private string countField;
        
        private string booleanListField;
        
        private CodeOrNullListType categoryListField;
        
        private MeasureOrNullListType quantityListField;
        
        private string countListField;
        
        private CategoryExtentType categoryExtentField;
        
        private QuantityExtentType quantityExtentField;
        
        private string countExtentField;
        
        private CompositeValueType compositeValueField;
        
        private object _ObjectField;
        
        private string nullField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public bool Boolean {
            get {
                return this.booleanField;
            }
            set {
                this.booleanField = value;
            }
        }
        
        /// <remarks/>
        public CodeType1 Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public MeasureType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public string BooleanList {
            get {
                return this.booleanListField;
            }
            set {
                this.booleanListField = value;
            }
        }
        
        /// <remarks/>
        public CodeOrNullListType CategoryList {
            get {
                return this.categoryListField;
            }
            set {
                this.categoryListField = value;
            }
        }
        
        /// <remarks/>
        public MeasureOrNullListType QuantityList {
            get {
                return this.quantityListField;
            }
            set {
                this.quantityListField = value;
            }
        }
        
        /// <remarks/>
        public string CountList {
            get {
                return this.countListField;
            }
            set {
                this.countListField = value;
            }
        }
        
        /// <remarks/>
        public CategoryExtentType CategoryExtent {
            get {
                return this.categoryExtentField;
            }
            set {
                this.categoryExtentField = value;
            }
        }
        
        /// <remarks/>
        public QuantityExtentType QuantityExtent {
            get {
                return this.quantityExtentField;
            }
            set {
                this.quantityExtentField = value;
            }
        }
        
        /// <remarks/>
        public string CountExtent {
            get {
                return this.countExtentField;
            }
            set {
                this.countExtentField = value;
            }
        }
        
        /// <remarks/>
        public CompositeValueType CompositeValue {
            get {
                return this.compositeValueField;
            }
            set {
                this.compositeValueField = value;
            }
        }
        
        /// <remarks/>
        public object _Object {
            get {
                return this._ObjectField;
            }
            set {
                this._ObjectField = value;
            }
        }
        
        /// <remarks/>
        public string Null {
            get {
                return this.nullField;
            }
            set {
                this.nullField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
