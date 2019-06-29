namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("coverageFunction", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CoverageFunctionType {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("CoverageMappingRule", typeof(MappingRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("GridFunction", typeof(GridFunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("MappingRule", typeof(StringOrRefType))]
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
