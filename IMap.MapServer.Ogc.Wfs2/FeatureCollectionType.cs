namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureCollection", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class FeatureCollectionType : SimpleFeatureCollectionType {
        
        private additionalObjects additionalObjectsField;
        
        private truncatedResponse truncatedResponseField;
        
        private System.DateTime timeStampField;
        
        private string numberMatchedField;
        
        private string numberReturnedField;
        
        private string nextField;
        
        private string previousField;
        
        private string lockIdField;
        
        
        public additionalObjects additionalObjects {
            get {
                return this.additionalObjectsField;
            }
            set {
                this.additionalObjectsField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId {
            get {
                return this.lockIdField;
            }
            set {
                this.lockIdField = value;
            }
        }
    }
}
