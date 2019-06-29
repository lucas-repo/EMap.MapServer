namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Exception {
        
        private string[] formatField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public string[] Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    }
}
