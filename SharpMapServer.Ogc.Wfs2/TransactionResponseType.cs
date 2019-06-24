namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TransactionResponse", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class TransactionResponseType {
        
        private TransactionSummaryType transactionSummaryField;
        
        private CreatedOrModifiedFeatureType[] insertResultsField;
        
        private CreatedOrModifiedFeatureType[] updateResultsField;
        
        private CreatedOrModifiedFeatureType[] replaceResultsField;
        
        private string versionField;
        
        
        public TransactionSummaryType TransactionSummary {
            get {
                return this.transactionSummaryField;
            }
            set {
                this.transactionSummaryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public CreatedOrModifiedFeatureType[] InsertResults {
            get {
                return this.insertResultsField;
            }
            set {
                this.insertResultsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public CreatedOrModifiedFeatureType[] UpdateResults {
            get {
                return this.updateResultsField;
            }
            set {
                this.updateResultsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable=false)]
        public CreatedOrModifiedFeatureType[] ReplaceResults {
            get {
                return this.replaceResultsField;
            }
            set {
                this.replaceResultsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
