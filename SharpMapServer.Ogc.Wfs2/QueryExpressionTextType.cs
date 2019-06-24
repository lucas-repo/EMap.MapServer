namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class QueryExpressionTextType {
        
        private System.Xml.XmlElement itemField;
        
        private string[] textField;
        
        private System.Xml.XmlQualifiedName[] returnFeatureTypesField;
        
        private string languageField;
        
        private bool isPrivateField;
        
        public QueryExpressionTextType() {
            this.isPrivateField = false;
        }
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName[] returnFeatureTypes {
            get {
                return this.returnFeatureTypesField;
            }
            set {
                this.returnFeatureTypesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
            }
        }
    }
}
