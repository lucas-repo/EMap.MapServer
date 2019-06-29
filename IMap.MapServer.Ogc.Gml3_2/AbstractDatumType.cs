namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractDatumType : IdentifiedObjectType {
        
        private domainOfValidity domainOfValidityField;
        
        private string[] scopeField;
        
        private CodeType anchorDefinitionField;
        
        private System.DateTime realizationEpochField;
        
        private bool realizationEpochFieldSpecified;
        
        
        public domainOfValidity domainOfValidity {
            get {
                return this.domainOfValidityField;
            }
            set {
                this.domainOfValidityField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("scope")]
        public string[] scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        
        public CodeType anchorDefinition {
            get {
                return this.anchorDefinitionField;
            }
            set {
                this.anchorDefinitionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime realizationEpoch {
            get {
                return this.realizationEpochField;
            }
            set {
                this.realizationEpochField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool realizationEpochSpecified {
            get {
                return this.realizationEpochFieldSpecified;
            }
            set {
                this.realizationEpochFieldSpecified = value;
            }
        }
    }
}
