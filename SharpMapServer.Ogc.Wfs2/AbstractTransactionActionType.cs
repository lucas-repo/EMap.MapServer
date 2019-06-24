namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NativeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReplaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsertType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public abstract partial class AbstractTransactionActionType {
        
        private string handleField;
        
        
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
