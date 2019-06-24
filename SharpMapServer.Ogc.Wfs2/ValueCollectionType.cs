namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ValueCollection", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ValueCollectionType {
        
        private MemberPropertyType[] memberField;
        
        private additionalValues additionalValuesField;
        
        private truncatedResponse truncatedResponseField;
        
        private System.DateTime timeStampField;
        
        private string numberMatchedField;
        
        private string numberReturnedField;
        
        private string nextField;
        
        private string previousField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        
        public additionalValues additionalValues {
            get {
                return this.additionalValuesField;
            }
            set {
                this.additionalValuesField = value;
            }
        }
        
        
        public truncatedResponse truncatedResponse {
            get {
                return this.truncatedResponseField;
            }
            set {
                this.truncatedResponseField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime timeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numberMatched {
            get {
                return this.numberMatchedField;
            }
            set {
                this.numberMatchedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string numberReturned {
            get {
                return this.numberReturnedField;
            }
            set {
                this.numberReturnedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string next {
            get {
                return this.nextField;
            }
            set {
                this.nextField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string previous {
            get {
                return this.previousField;
            }
            set {
                this.previousField = value;
            }
        }
    }
}
