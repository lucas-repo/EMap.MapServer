namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatrixType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataArray", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataArrayType : AbstractDataComponentType {
        
        private CountPropertyType elementCountField;
        
        private DataArrayTypeElementType elementTypeField;
        
        private DataArrayTypeEncoding encodingField;
        
        private EncodedValuesPropertyType valuesField;
        
        
        public CountPropertyType elementCount {
            get {
                return this.elementCountField;
            }
            set {
                this.elementCountField = value;
            }
        }
        
        
        public DataArrayTypeElementType elementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        
        public DataArrayTypeEncoding encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
        
        
        public EncodedValuesPropertyType values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
            }
        }
    }
}
