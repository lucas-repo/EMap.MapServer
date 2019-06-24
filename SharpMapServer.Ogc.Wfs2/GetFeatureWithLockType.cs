namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureWithLock", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class GetFeatureWithLockType : GetFeatureType {
        
        private string expiryField;
        
        private AllSomeType lockActionField;
        
        public GetFeatureWithLockType() {
            this.expiryField = "300";
            this.lockActionField = AllSomeType.ALL;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("300")]
        public string expiry {
            get {
                return this.expiryField;
            }
            set {
                this.expiryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AllSomeType.ALL)]
        public AllSomeType lockAction {
            get {
                return this.lockActionField;
            }
            set {
                this.lockActionField = value;
            }
        }
    }
}
