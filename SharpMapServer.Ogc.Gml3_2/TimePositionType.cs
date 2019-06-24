namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("timePosition", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimePositionType {
        
        private string frameField;
        
        private string calendarEraNameField;
        
        private TimeIndeterminateValueType indeterminatePositionField;
        
        private bool indeterminatePositionFieldSpecified;
        
        private string valueField;
        
        public TimePositionType() {
            this.frameField = "#ISO-8601";
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string calendarEraName {
            get {
                return this.calendarEraNameField;
            }
            set {
                this.calendarEraNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeIndeterminateValueType indeterminatePosition {
            get {
                return this.indeterminatePositionField;
            }
            set {
                this.indeterminatePositionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indeterminatePositionSpecified {
            get {
                return this.indeterminatePositionFieldSpecified;
            }
            set {
                this.indeterminatePositionFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
