namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Post {
        
        private OnlineResource onlineResourceField;
        
        
        public OnlineResource OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
    }
}
