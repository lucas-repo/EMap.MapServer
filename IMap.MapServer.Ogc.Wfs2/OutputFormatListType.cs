namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class OutputFormatListType {
        
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
