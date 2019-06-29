namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeReferenceSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeReferenceSystemType : DefinitionType {
        
        private string domainOfValidityField;
        
        
        public string domainOfValidity {
            get {
                return this.domainOfValidityField;
            }
            set {
                this.domainOfValidityField = value;
            }
        }
    }
}
