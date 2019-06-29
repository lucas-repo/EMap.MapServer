namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class TransactionSummaryType {
        
        private string totalInsertedField;
        
        private string totalUpdatedField;
        
        private string totalReplacedField;
        
        private string totalDeletedField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string totalInserted {
            get {
                return this.totalInsertedField;
            }
            set {
                this.totalInsertedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string totalUpdated {
            get {
                return this.totalUpdatedField;
            }
            set {
                this.totalUpdatedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string totalReplaced {
            get {
                return this.totalReplacedField;
            }
            set {
                this.totalReplacedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string totalDeleted {
            get {
                return this.totalDeletedField;
            }
            set {
                this.totalDeletedField = value;
            }
        }
    }
}
