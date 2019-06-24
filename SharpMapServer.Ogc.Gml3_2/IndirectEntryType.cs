namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("indirectEntry", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class IndirectEntryType {
        
        private DefinitionProxyType definitionProxyField;
        
        
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
