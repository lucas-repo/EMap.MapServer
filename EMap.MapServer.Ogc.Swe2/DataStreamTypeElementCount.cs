namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamTypeElementCount {
        
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
