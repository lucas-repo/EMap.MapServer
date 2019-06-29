namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeStoredQueriesResponse", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class DescribeStoredQueriesResponseType {
        
        private StoredQueryDescriptionType[] storedQueryDescriptionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryDescription")]
        public StoredQueryDescriptionType[] StoredQueryDescription {
            get {
                return this.storedQueryDescriptionField;
            }
            set {
                this.storedQueryDescriptionField = value;
            }
        }
    }
}
