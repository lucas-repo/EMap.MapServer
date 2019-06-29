namespace IMap.MapServer.Ogc.Ows1_1 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(WFS_CapabilitiesType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    public partial class CapabilitiesBaseType {
        
        private ServiceIdentification serviceIdentificationField;
        
        private ServiceProvider serviceProviderField;
        
        private OperationsMetadata operationsMetadataField;
        
        private string versionField;
        
        private string updateSequenceField;
        
        
        public ServiceIdentification ServiceIdentification {
            get {
                return this.serviceIdentificationField;
            }
            set {
                this.serviceIdentificationField = value;
            }
        }
        
        
        public ServiceProvider ServiceProvider {
            get {
                return this.serviceProviderField;
            }
            set {
                this.serviceProviderField = value;
            }
        }
        
        
        public OperationsMetadata OperationsMetadata {
            get {
                return this.operationsMetadataField;
            }
            set {
                this.operationsMetadataField = value;
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
