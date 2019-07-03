namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ResourceId", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class ResourceIdType : AbstractIdType {
        
        private string ridField;
        
        private string previousRidField;
        
        private string versionField;
        
        private System.DateTime startDateField;
        
        private bool startDateFieldSpecified;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rid {
            get {
                return this.ridField;
            }
            set {
                this.ridField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string previousRid {
            get {
                return this.previousRidField;
            }
            set {
                this.previousRidField = value;
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
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }
    }
}
