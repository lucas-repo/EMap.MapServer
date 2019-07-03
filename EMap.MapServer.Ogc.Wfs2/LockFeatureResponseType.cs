namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("LockFeatureResponse", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class LockFeatureResponseType {
        
        private FeaturesLockedType featuresLockedField;
        
        private FeaturesNotLockedType featuresNotLockedField;
        
        private string lockIdField;
        
        
        public FeaturesLockedType FeaturesLocked {
            get {
                return this.featuresLockedField;
            }
            set {
                this.featuresLockedField = value;
            }
        }
        
        
        public FeaturesNotLockedType FeaturesNotLocked {
            get {
                return this.featuresNotLockedField;
            }
            set {
                this.featuresNotLockedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockId {
            get {
                return this.lockIdField;
            }
            set {
                this.lockIdField = value;
            }
        }
    }
}
