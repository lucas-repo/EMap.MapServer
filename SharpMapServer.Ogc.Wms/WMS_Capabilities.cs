namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class WMS_Capabilities {
        
        private Service serviceField;
        
        private Capability capabilityField;
        
        private string versionField;
        
        private string updateSequenceField;
        
        public WMS_Capabilities() {
            this.versionField = "1.3.0";
        }
        
        
        public Service Service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
        
        
        public Capability Capability {
            get {
                return this.capabilityField;
            }
            set {
                this.capabilityField = value;
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
        public string updateSequence {
            get {
                return this.updateSequenceField;
            }
            set {
                this.updateSequenceField = value;
            }
        }
    }
}
