namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTokensPropertyType {
        
        private AllowedTokensType allowedTokensField;
        
        
        public AllowedTokensType AllowedTokens {
            get {
                return this.allowedTokensField;
            }
            set {
                this.allowedTokensField = value;
            }
        }
    }
}
