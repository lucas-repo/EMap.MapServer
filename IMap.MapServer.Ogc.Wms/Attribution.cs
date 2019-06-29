namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Attribution {
        
        private string titleField;
        
        private OnlineResource onlineResourceField;
        
        private LogoURL logoURLField;
        
        
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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
        
        
        public LogoURL LogoURL {
            get {
                return this.logoURLField;
            }
            set {
                this.logoURLField = value;
            }
        }
    }
}
