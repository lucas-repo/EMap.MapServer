namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class GridLimitsType {
        
        private GridEnvelopeType gridEnvelopeField;
        
        
        public GridEnvelopeType GridEnvelope {
            get {
                return this.gridEnvelopeField;
            }
            set {
                this.gridEnvelopeField = value;
            }
        }
    }
}
