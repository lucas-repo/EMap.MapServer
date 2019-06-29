namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCoordinateSystem", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeCoordinateSystemType : AbstractTimeReferenceSystemType {
        
        private object itemField;
        
        private TimeIntervalLengthType intervalField;
        
        /// <remarks/>
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
        
        /// <remarks/>
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
