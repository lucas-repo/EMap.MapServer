namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageMappingRule", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MappingRuleType {
        
        private object itemField;
        
        
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
