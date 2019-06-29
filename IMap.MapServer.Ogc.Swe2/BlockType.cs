namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Block", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BlockType : AbstractSWEType {
        
        private string compressionField;
        
        private string encryptionField;
        
        private string paddingBytesafterField;
        
        private string paddingBytesbeforeField;
        
        private string byteLengthField;
        
        private string refField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string compression {
            get {
                return this.compressionField;
            }
            set {
                this.compressionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string encryption {
            get {
                return this.encryptionField;
            }
            set {
                this.encryptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-after", DataType="integer")]
        public string paddingBytesafter {
            get {
                return this.paddingBytesafterField;
            }
            set {
                this.paddingBytesafterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-before", DataType="integer")]
        public string paddingBytesbefore {
            get {
                return this.paddingBytesbeforeField;
            }
            set {
                this.paddingBytesbeforeField = value;
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
