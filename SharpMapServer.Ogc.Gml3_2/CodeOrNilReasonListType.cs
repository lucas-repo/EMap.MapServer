namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryExtentType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CategoryList", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CodeOrNilReasonListType {
        
        private string codeSpaceField;
        
        private string[] textField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string codeSpace {
            get {
                return this.codeSpaceField;
            }
            set {
                this.codeSpaceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
}
