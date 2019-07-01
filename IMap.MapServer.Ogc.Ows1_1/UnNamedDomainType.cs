namespace EMap.MapServer.Ogc.Ows1_1 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    public partial class UnNamedDomainType {
        
        private object[] allowedValuesField;
        
        private AnyValue anyValueField;
        
        private NoValues noValuesField;
        
        private ValuesReference valuesReferenceField;
        
        private ValueType defaultValueField;
        
        private DomainMetadataType meaningField;
        
        private DomainMetadataType dataTypeField;
        
        private DomainMetadataType uOMField;
        
        private DomainMetadataType referenceSystemField;
        
        private MetadataType[] metadataField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Range", typeof(RangeType), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", typeof(ValueType), IsNullable=false)]
        public object[] AllowedValues {
            get {
                return this.allowedValuesField;
            }
            set {
                this.allowedValuesField = value;
            }
        }
        
        
        public AnyValue AnyValue {
            get {
                return this.anyValueField;
            }
            set {
                this.anyValueField = value;
            }
        }
        
        
        public NoValues NoValues {
            get {
                return this.noValuesField;
            }
            set {
                this.noValuesField = value;
            }
        }
        
        
        public ValuesReference ValuesReference {
            get {
                return this.valuesReferenceField;
            }
            set {
                this.valuesReferenceField = value;
            }
        }
        
        
        public ValueType DefaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
        
        
        public DomainMetadataType Meaning {
            get {
                return this.meaningField;
            }
            set {
                this.meaningField = value;
            }
        }
        
        
        public DomainMetadataType DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        
        public DomainMetadataType UOM {
            get {
                return this.uOMField;
            }
            set {
                this.uOMField = value;
            }
        }
        
        
        public DomainMetadataType ReferenceSystem {
            get {
                return this.referenceSystemField;
            }
            set {
                this.referenceSystemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
}
