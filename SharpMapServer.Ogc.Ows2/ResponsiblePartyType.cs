namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PointOfContact", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ResponsiblePartyType {
        
        private string individualNameField;
        
        private string organisationNameField;
        
        private string positionNameField;
        
        private ContactType contactInfoField;
        
        private CodeType1 roleField;
        
        
        public string IndividualName {
            get {
                return this.individualNameField;
            }
            set {
                this.individualNameField = value;
            }
        }
        
        
        public string OrganisationName {
            get {
                return this.organisationNameField;
            }
            set {
                this.organisationNameField = value;
            }
        }
        
        
        public string PositionName {
            get {
                return this.positionNameField;
            }
            set {
                this.positionNameField = value;
            }
        }
        
        
        public ContactType ContactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
            }
        }
        
        
        public CodeType1 Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
    }
}
