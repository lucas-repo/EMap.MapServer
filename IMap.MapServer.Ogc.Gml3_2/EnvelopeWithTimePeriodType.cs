namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("EnvelopeWithTimePeriod", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class EnvelopeWithTimePeriodType : EnvelopeType {
        
        private TimePositionType beginPositionField;
        
        private TimePositionType endPositionField;
        
        private string frameField;
        
        public EnvelopeWithTimePeriodType() {
            this.frameField = "#ISO-8601";
        }
        
        
        public TimePositionType beginPosition {
            get {
                return this.beginPositionField;
            }
            set {
                this.beginPositionField = value;
            }
        }
        
        
        public TimePositionType endPosition {
            get {
                return this.endPositionField;
            }
            set {
                this.endPositionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        public string frame {
            get {
                return this.frameField;
            }
            set {
                this.frameField = value;
            }
        }
    }
}
