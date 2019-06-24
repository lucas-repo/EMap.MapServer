namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("BinaryEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BinaryEncodingType : AbstractEncodingType {
        
        private BinaryEncodingTypeMember[] memberField;
        
        private ByteOrderType byteOrderField;
        
        private ByteEncodingType byteEncodingField;
        
        private string byteLengthField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public BinaryEncodingTypeMember[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ByteOrderType byteOrder {
            get {
                return this.byteOrderField;
            }
            set {
                this.byteOrderField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ByteEncodingType byteEncoding {
            get {
                return this.byteEncodingField;
            }
            set {
                this.byteEncodingField = value;
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
    }
}
