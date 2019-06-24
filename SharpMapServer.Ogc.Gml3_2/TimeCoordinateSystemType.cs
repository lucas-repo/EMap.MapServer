namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCoordinateSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeCoordinateSystemType : TimeReferenceSystemType {
        
        private object itemField;
        
        private TimeIntervalLengthType intervalField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("origin", typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("originPosition", typeof(TimePositionType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public TimeIntervalLengthType interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
            }
        }
    }
}
