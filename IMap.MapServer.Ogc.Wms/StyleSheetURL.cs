namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class StyleSheetURL {
        
        private string formatField;
        
        private OnlineResource onlineResourceField;
        
        
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
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
    }
}
