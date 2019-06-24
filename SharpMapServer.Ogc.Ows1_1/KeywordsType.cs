namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class KeywordsType {
        
        private LanguageStringType[] keywordField;
        
        private CodeType typeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public LanguageStringType[] Keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }
        
        
        public CodeType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
