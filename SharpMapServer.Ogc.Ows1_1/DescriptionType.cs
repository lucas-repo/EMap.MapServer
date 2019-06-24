namespace SharpMapServer.Ogc.Ows1_1 {


    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatasetDescriptionSummaryBaseType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(LayerType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    public partial class DescriptionType {
        
        private LanguageStringType[] titleField;
        
        private LanguageStringType[] abstractField;
        
        private KeywordsType[] keywordsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public LanguageStringType[] Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public LanguageStringType[] Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Keywords")]
        public KeywordsType[] Keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
    }
}
