namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class LowerBoundaryType {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
