namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Matrix", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class MatrixType : DataArrayType {
        
        private string referenceFrameField;
        
        private string localFrameField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
}
