namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LockFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateStoredQueryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeStoredQueriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListStoredQueriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetFeatureWithLockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetPropertyValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeFeatureTypeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public abstract partial class BaseRequestType {
        
        private string serviceField;
        
        private string versionField;
        
        private string handleField;
        
        public BaseRequestType() {
            this.serviceField = "WFS";
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle {
            get {
                return this.handleField;
            }
            set {
                this.handleField = value;
            }
        }
    }
}
