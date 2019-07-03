namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeStoredQueries", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class DescribeStoredQueriesType : BaseRequestType {
        
        private string[] storedQueryIdField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("StoredQueryId", DataType="anyURI")]
        public string[] StoredQueryId {
            get {
                return this.storedQueryIdField;
            }
            set {
                this.storedQueryIdField = value;
            }
        }
    }
}
