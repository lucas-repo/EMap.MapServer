namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coverageFunction", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CoverageFunctionType {
        
        private object itemField;
        
        /// <remarks/>
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
