namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute("HTTP", Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class HTTP1 {
        
        private Get getField;
        
        private Post postField;
        
        
        public Get Get {
            get {
                return this.getField;
            }
            set {
                this.getField = value;
            }
        }
        
        
        public Post Post {
            get {
                return this.postField;
            }
            set {
                this.postField = value;
            }
        }
    }
}
