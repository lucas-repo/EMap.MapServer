namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageMappingRule", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MappingRuleType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ruleDefinition", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ruleReference", typeof(ReferenceType))]
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
