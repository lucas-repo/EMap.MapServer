namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class KeywordsType {
        
        private LanguageStringType[] keywordField;
        
        private CodeType1 typeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public LanguageStringType[] Keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }
        
        
        public CodeType1 Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
