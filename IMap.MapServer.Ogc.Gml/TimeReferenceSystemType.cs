namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeOrdinalReferenceSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeClockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCalendarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCoordinateSystemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeReferenceSystem", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeReferenceSystemType : DefinitionType {
        
        private string domainOfValidityField;
        
        /// <remarks/>
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
