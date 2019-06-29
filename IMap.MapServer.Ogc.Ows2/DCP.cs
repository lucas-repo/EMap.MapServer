namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class DCP {
        
        private HTTP itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("HTTP")]
        public HTTP Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
