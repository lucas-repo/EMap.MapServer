namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class KeywordList {
        
        private Keyword[] keywordField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public Keyword[] Keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }
    }
}
