namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class PropertyIsLikeType : ComparisonOpsType {
        
        private object[] expressionField;
        
        private string wildCardField;
        
        private string singleCharField;
        
        private string escapeCharField;
        
        private bool matchCaseField;
        
        public PropertyIsLikeType() {
            this.matchCaseField = true;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public object[] expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wildCard {
            get {
                return this.wildCardField;
            }
            set {
                this.wildCardField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string singleChar {
            get {
                return this.singleCharField;
            }
            set {
                this.singleCharField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string escapeChar {
            get {
                return this.escapeCharField;
            }
            set {
                this.escapeCharField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase {
            get {
                return this.matchCaseField;
            }
            set {
                this.matchCaseField = value;
            }
        }
    }
}
