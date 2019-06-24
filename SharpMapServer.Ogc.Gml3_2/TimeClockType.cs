namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeClock", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeClockType : TimeReferenceSystemType {
        
        private StringOrRefType referenceEventField;
        
        private System.DateTime referenceTimeField;
        
        private System.DateTime utcReferenceField;
        
        private TimeCalendarPropertyType[] dateBasisField;
        
        
        public StringOrRefType referenceEvent {
            get {
                return this.referenceEventField;
            }
            set {
                this.referenceEventField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime utcReference {
            get {
                return this.utcReferenceField;
            }
            set {
                this.utcReferenceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("dateBasis")]
        public TimeCalendarPropertyType[] dateBasis {
            get {
                return this.dateBasisField;
            }
            set {
                this.dateBasisField = value;
            }
        }
    }
}
