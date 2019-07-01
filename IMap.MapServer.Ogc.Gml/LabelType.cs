namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class LabelType {
        
        private string[] labelExpressionField;
        
        private string[] textField;
        
        private string transformField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LabelExpression")]
        public string[] LabelExpression {
            get {
                return this.labelExpressionField;
            }
            set {
                this.labelExpressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string transform {
            get {
                return this.transformField;
            }
            set {
                this.transformField = value;
            }
        }
    }
}
