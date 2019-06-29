namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendarEra", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeCalendarEraType : DefinitionType {
        
        private StringOrRefType referenceEventField;
        
        private System.DateTime referenceDateField;
        
        private decimal julianReferenceField;
        
        private TimePeriodPropertyType epochOfUseField;
        
        public TimeCalendarEraType() {
            this.referenceDateField = new System.DateTime(0);
        }
        
        /// <remarks/>
        public StringOrRefType referenceEvent {
            get {
                return this.referenceEventField;
            }
            set {
                this.referenceEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.ComponentModel.DefaultValueAttribute(typeof(System.DateTime), "0001-01-01")]
        public System.DateTime referenceDate {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        /// <remarks/>
        public decimal julianReference {
            get {
                return this.julianReferenceField;
            }
            set {
                this.julianReferenceField = value;
            }
        }
        
        /// <remarks/>
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
