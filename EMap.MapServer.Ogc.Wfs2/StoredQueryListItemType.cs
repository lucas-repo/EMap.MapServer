namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class StoredQueryListItemType {
        
        private Title[] titleField;
        
        private System.Xml.XmlQualifiedName[] returnFeatureTypeField;
        
        private string idField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ReturnFeatureType")]
        public System.Xml.XmlQualifiedName[] ReturnFeatureType {
            get {
                return this.returnFeatureTypeField;
            }
            set {
                this.returnFeatureTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
