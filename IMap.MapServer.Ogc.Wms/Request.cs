namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Request {
        
        private OperationType getCapabilitiesField;
        
        private OperationType getMapField;
        
        private OperationType getFeatureInfoField;
        
        private OperationType[] _ExtendedOperationField;
        
        
        public OperationType GetCapabilities {
            get {
                return this.getCapabilitiesField;
            }
            set {
                this.getCapabilitiesField = value;
            }
        }
        
        
        public OperationType GetMap {
            get {
                return this.getMapField;
            }
            set {
                this.getMapField = value;
            }
        }
        
        
        public OperationType GetFeatureInfo {
            get {
                return this.getFeatureInfoField;
            }
            set {
                this.getFeatureInfoField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("_ExtendedOperation")]
        public OperationType[] _ExtendedOperation {
            get {
                return this._ExtendedOperationField;
            }
            set {
                this._ExtendedOperationField = value;
            }
        }
    }
}
