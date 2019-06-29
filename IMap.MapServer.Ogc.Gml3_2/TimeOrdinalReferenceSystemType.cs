namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalReferenceSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeOrdinalReferenceSystemType : TimeReferenceSystemType {
        
        private TimeOrdinalEraPropertyType[] componentField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("component")]
        public TimeOrdinalEraPropertyType[] component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
    }
}
