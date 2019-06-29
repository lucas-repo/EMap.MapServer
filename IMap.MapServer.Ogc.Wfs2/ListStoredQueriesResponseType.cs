namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ListStoredQueriesResponse", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ListStoredQueriesResponseType {
        
        private StoredQueryListItemType[] storedQueryField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("StoredQuery")]
        public StoredQueryListItemType[] StoredQuery {
            get {
                return this.storedQueryField;
            }
            set {
                this.storedQueryField = value;
            }
        }
    }
}
