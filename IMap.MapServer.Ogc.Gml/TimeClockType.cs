namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeClock", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeClockType : AbstractTimeReferenceSystemType {
        
        private StringOrRefType referenceEventField;
        
        private System.DateTime referenceTimeField;
        
        private System.DateTime utcReferenceField;
        
        private TimeCalendarPropertyType[] dateBasisField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime utcReference {
            get {
                return this.utcReferenceField;
            }
            set {
                this.utcReferenceField = value;
            }
        }
        
        /// <remarks/>
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
