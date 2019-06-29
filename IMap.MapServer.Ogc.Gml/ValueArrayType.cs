namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ValueArray", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ValueArrayType : CompositeValueType {
        
        private string codeSpaceField;
        
        private string uomField;
        
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}
