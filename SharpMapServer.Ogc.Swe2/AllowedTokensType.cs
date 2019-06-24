namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedTokens", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AllowedTokensType : AbstractSWEType {
        
        private string[] valueField;
        
        private string patternField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        
        public string pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
    }
}
