namespace EMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class DCPType {
        
        private HTTP1 hTTPField;
        
        
        public HTTP1 HTTP {
            get {
                return this.hTTPField;
            }
            set {
                this.hTTPField = value;
            }
        }
    }
}
