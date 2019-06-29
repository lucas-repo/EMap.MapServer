namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class GridEnvelopeType {
        
        private string lowField;
        
        private string highField;
        
        
        public string low {
            get {
                return this.lowField;
            }
            set {
                this.lowField = value;
            }
        }
        
        
        public string high {
            get {
                return this.highField;
            }
            set {
                this.highField = value;
            }
        }
    }
}
