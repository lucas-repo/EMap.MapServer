namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateStoredQueryResponseType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DropStoredQueryResponse", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ExecutionStatusType {
        
        private string statusField;
        
        public ExecutionStatusType() {
            this.statusField = "OK";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
}
