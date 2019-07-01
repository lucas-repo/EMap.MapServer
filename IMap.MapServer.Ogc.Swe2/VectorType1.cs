namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="VectorType", Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Vector", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class VectorType1 : AbstractDataComponentType {
        
        private VectorTypeCoordinate[] coordinateField;
        
        private string referenceFrameField;
        
        private string localFrameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("coordinate")]
        public VectorTypeCoordinate[] coordinate {
            get {
                return this.coordinateField;
            }
            set {
                this.coordinateField = value;
            }
        }
        
        
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
