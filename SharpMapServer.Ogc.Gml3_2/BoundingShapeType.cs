namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("boundedBy", Namespace="http://www.opengis.net/gml/3.2", IsNullable=true)]
    public partial class BoundingShapeType {
        
        private object itemField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType))]
        [System.Xml.Serialization.XmlElementAttribute("Null", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
