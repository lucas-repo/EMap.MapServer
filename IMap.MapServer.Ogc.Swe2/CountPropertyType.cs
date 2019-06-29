namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class CountPropertyType {
        
        private CountType countField;
        
        
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
}
