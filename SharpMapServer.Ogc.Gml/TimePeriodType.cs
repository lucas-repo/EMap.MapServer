namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimePeriod", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimePeriodType : AbstractTimeGeometricPrimitiveType {
        
        private object itemField;
        
        private object item1Field;
        
        private string durationField;
        
        private TimeIntervalLengthType timeIntervalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("begin", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("beginPosition", typeof(TimePositionType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("endPosition", typeof(TimePositionType))]
        public object Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
        
        /// <remarks/>
        public TimeIntervalLengthType timeInterval {
            get {
                return this.timeIntervalField;
            }
            set {
                this.timeIntervalField = value;
            }
        }
    }
}
