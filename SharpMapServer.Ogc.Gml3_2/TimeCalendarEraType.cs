namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendarEra", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeCalendarEraType : DefinitionType {
        
        private StringOrRefType referenceEventField;
        
        private string referenceDateField;
        
        private decimal julianReferenceField;
        
        private TimePeriodPropertyType epochOfUseField;
        
        
        public StringOrRefType referenceEvent {
            get {
                return this.referenceEventField;
            }
            set {
                this.referenceEventField = value;
            }
        }
        
        
        public string referenceDate {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        
        public decimal julianReference {
            get {
                return this.julianReferenceField;
            }
            set {
                this.julianReferenceField = value;
            }
        }
        
        
        public TimePeriodPropertyType epochOfUse {
            get {
                return this.epochOfUseField;
            }
            set {
                this.epochOfUseField = value;
            }
        }
    }
}
