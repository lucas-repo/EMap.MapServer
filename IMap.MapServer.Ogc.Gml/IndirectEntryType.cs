namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("indirectEntry", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class IndirectEntryType {
        
        private DefinitionProxyType definitionProxyField;
        
        /// <remarks/>
        public DefinitionProxyType DefinitionProxy {
            get {
                return this.definitionProxyField;
            }
            set {
                this.definitionProxyField = value;
            }
        }
    }
}
