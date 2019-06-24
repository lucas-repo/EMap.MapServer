namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class DirectionDescriptionType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("compassPoint", typeof(CompassPointEnumeration))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("keyword", typeof(CodeType))]
        [System.Xml.Serialization.XmlElementAttribute("reference", typeof(ReferenceType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
