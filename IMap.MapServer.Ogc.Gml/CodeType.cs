namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeWithAuthorityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LocalName", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
    public partial class CodeType {
        
        private string codeSpaceField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string codeSpace {
            get {
                return this.codeSpaceField;
            }
            set {
                this.codeSpaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
