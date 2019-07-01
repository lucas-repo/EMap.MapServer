namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Component", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class ComponentType : AbstractSWEType {
        
        private string encryptionField;
        
        private string significantBitsField;
        
        private string bitLengthField;
        
        private string byteLengthField;
        
        private string dataTypeField;
        
        private string refField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string encryption {
            get {
                return this.encryptionField;
            }
            set {
                this.encryptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string significantBits {
            get {
                return this.significantBitsField;
            }
            set {
                this.significantBitsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string bitLength {
            get {
                return this.bitLengthField;
            }
            set {
                this.bitLengthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string byteLength {
            get {
                return this.byteLengthField;
            }
            set {
                this.byteLengthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string dataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
}
