namespace EMap.MapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class ServiceProvider {
        
        private string providerNameField;
        
        private OnlineResourceType providerSiteField;
        
        private ResponsiblePartySubsetType serviceContactField;
        
        
        public string ProviderName {
            get {
                return this.providerNameField;
            }
            set {
                this.providerNameField = value;
            }
        }
        
        
        public OnlineResourceType ProviderSite {
            get {
                return this.providerSiteField;
            }
            set {
                this.providerSiteField = value;
            }
        }
        
        
        public ResponsiblePartySubsetType ServiceContact {
            get {
                return this.serviceContactField;
            }
            set {
                this.serviceContactField = value;
            }
        }
    }
}
