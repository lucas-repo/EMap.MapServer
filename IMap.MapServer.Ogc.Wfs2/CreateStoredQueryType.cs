namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CreateStoredQuery", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class CreateStoredQueryType : BaseRequestType {
        
        private StoredQueryDescriptionType[] storedQueryDefinitionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryDefinition")]
        public StoredQueryDescriptionType[] StoredQueryDefinition {
            get {
                return this.storedQueryDefinitionField;
            }
            set {
                this.storedQueryDefinitionField = value;
            }
        }
    }
}
