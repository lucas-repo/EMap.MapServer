namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class OperationType {
        
        private string[] formatField;
        
        private DCPType[] dCPTypeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public string[] Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DCPType")]
        public DCPType[] DCPType {
            get {
                return this.dCPTypeField;
            }
            set {
                this.dCPTypeField = value;
            }
        }
    }
}
