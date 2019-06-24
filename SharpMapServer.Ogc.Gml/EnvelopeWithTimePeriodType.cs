namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("EnvelopeWithTimePeriod", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EnvelopeWithTimePeriodType : EnvelopeType {
        
        private TimePositionType[] timePositionField;
        
        private string frameField;
        
        public EnvelopeWithTimePeriodType() {
            this.frameField = "#ISO-8601";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timePosition")]
        public TimePositionType[] timePosition {
            get {
                return this.timePositionField;
            }
            set {
                this.timePositionField = value;
            }
        }
        
        /// <remarks/>
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
