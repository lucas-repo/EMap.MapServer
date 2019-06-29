namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedValuesPropertyType {
        
        private AllowedValuesType allowedValuesField;
        
        
        public AllowedValuesType AllowedValues {
            get {
                return this.allowedValuesField;
            }
            set {
                this.allowedValuesField = value;
            }
        }
    }
}
