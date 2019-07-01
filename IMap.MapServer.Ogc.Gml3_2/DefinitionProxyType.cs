namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DefinitionProxy", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DefinitionProxyType : DefinitionType {
        
        private ReferenceType definitionRefField;
        
        
        public ReferenceType definitionRef {
            get {
                return this.definitionRefField;
            }
            set {
                this.definitionRefField = value;
            }
        }
    }
}
