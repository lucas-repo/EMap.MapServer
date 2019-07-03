namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTimesPropertyType {
        
        private AllowedTimesType allowedTimesField;
        
        
        public AllowedTimesType AllowedTimes {
            get {
                return this.allowedTimesField;
            }
            set {
                this.allowedTimesField = value;
            }
        }
    }
}
