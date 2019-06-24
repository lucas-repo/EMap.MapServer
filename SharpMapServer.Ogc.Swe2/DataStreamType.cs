namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataStream", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataStreamType : AbstractSWEIdentifiableType {
        
        private DataStreamTypeElementCount elementCountField;
        
        private DataStreamTypeElementType elementTypeField;
        
        private DataStreamTypeEncoding encodingField;
        
        private EncodedValuesPropertyType valuesField;
        
        
        public DataStreamTypeElementCount elementCount {
            get {
                return this.elementCountField;
            }
            set {
                this.elementCountField = value;
            }
        }
        
        
        public DataStreamTypeElementType elementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        
        public DataStreamTypeEncoding encoding {
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
