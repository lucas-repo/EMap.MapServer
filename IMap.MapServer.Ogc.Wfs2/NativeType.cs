namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Native", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class NativeType : AbstractTransactionActionType {
        
        private System.Xml.XmlNode[] anyField;
        
        private string vendorIdField;
        
        private bool safeToIgnoreField;
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vendorId {
            get {
                return this.vendorIdField;
            }
            set {
                this.vendorIdField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool safeToIgnore {
            get {
                return this.safeToIgnoreField;
            }
            set {
                this.safeToIgnoreField = value;
            }
        }
    }
}
