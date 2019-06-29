namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Capability {
        
        private Request requestField;
        
        private string[] exceptionField;
        
        private object[] _ExtendedCapabilitiesField;
        
        private Layer layerField;
        
        
        public Request Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Format", IsNullable=false)]
        public string[] Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("_ExtendedCapabilities")]
        public object[] _ExtendedCapabilities {
            get {
                return this._ExtendedCapabilitiesField;
            }
            set {
                this._ExtendedCapabilitiesField = value;
            }
        }
        
        
        public Layer Layer {
            get {
                return this.layerField;
            }
            set {
                this.layerField = value;
            }
        }
    }
}
