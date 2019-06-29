namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    public partial class TelephoneType {
        
        private string[] voiceField;
        
        private string[] facsimileField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Voice")]
        public string[] Voice {
            get {
                return this.voiceField;
            }
            set {
                this.voiceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Facsimile")]
        public string[] Facsimile {
            get {
                return this.facsimileField;
            }
            set {
                this.facsimileField = value;
            }
        }
    }
}
