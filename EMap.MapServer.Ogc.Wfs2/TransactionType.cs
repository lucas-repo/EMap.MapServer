namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Transaction", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class TransactionType : BaseRequestType {
        
        private AbstractTransactionActionType[] itemsField;
        
        private string lockIdField;
        
        private AllSomeType releaseActionField;
        
        private string srsNameField;
        
        public TransactionType() {
            this.releaseActionField = AllSomeType.ALL;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Delete", typeof(DeleteType))]
        [System.Xml.Serialization.XmlElementAttribute("Insert", typeof(InsertType))]
        [System.Xml.Serialization.XmlElementAttribute("Native", typeof(NativeType))]
        [System.Xml.Serialization.XmlElementAttribute("Replace", typeof(ReplaceType))]
        [System.Xml.Serialization.XmlElementAttribute("Update", typeof(UpdateType))]
        public AbstractTransactionActionType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType releaseAction {
            get {
                return this.releaseActionField;
            }
            set {
                this.releaseActionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
    }
}
