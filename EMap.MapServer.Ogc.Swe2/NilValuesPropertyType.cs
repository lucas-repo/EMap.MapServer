namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class NilValuesPropertyType {
        
        private NilValuesType nilValuesField;
        
        
        public NilValuesType NilValues {
            get {
                return this.nilValuesField;
            }
            set {
                this.nilValuesField = value;
            }
        }
    }
}
