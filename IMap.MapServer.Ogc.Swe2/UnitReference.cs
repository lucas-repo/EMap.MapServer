namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class UnitReference {
        
        private string codeField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
}
