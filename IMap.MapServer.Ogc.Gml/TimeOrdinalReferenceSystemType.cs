namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalReferenceSystem", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimeOrdinalReferenceSystemType : AbstractTimeReferenceSystemType {
        
        private TimeOrdinalEraPropertyType[] componentField;
        
        /// <remarks/>
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
