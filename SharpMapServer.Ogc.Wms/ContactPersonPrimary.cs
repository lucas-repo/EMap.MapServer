namespace SharpMapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class ContactPersonPrimary {
        
        private string contactPersonField;
        
        private string contactOrganizationField;
        
        
        public string ContactPerson {
            get {
                return this.contactPersonField;
            }
            set {
                this.contactPersonField = value;
            }
        }
        
        
        public string ContactOrganization {
            get {
                return this.contactOrganizationField;
            }
            set {
                this.contactOrganizationField = value;
            }
        }
    }
}
