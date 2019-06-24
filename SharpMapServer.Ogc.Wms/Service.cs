namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Service {
        
        private ServiceName nameField;
        
        private string titleField;
        
        private string abstractField;
        
        private Keyword[] keywordListField;
        
        private OnlineResource onlineResourceField;
        
        private ContactInformation contactInformationField;
        
        private string feesField;
        
        private string accessConstraintsField;
        
        private string layerLimitField;
        
        private string maxWidthField;
        
        private string maxHeightField;
        
        
        public ServiceName Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        public string Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Keyword", IsNullable=false)]
        public Keyword[] KeywordList {
            get {
                return this.keywordListField;
            }
            set {
                this.keywordListField = value;
            }
        }
        
        
        public OnlineResource OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
        
        
        public ContactInformation ContactInformation {
            get {
                return this.contactInformationField;
            }
            set {
                this.contactInformationField = value;
            }
        }
        
        
        public string Fees {
            get {
                return this.feesField;
            }
            set {
                this.feesField = value;
            }
        }
        
        
        public string AccessConstraints {
            get {
                return this.accessConstraintsField;
            }
            set {
                this.accessConstraintsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string LayerLimit {
            get {
                return this.layerLimitField;
            }
            set {
                this.layerLimitField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxWidth {
            get {
                return this.maxWidthField;
            }
            set {
                this.maxWidthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxHeight {
            get {
                return this.maxHeightField;
            }
            set {
                this.maxHeightField = value;
            }
        }
    }
}
