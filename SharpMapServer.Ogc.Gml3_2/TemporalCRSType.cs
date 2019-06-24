namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TemporalCRSType : AbstractCRSType {
        
        private object itemField;
        
        private TemporalDatumPropertyType temporalDatumField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("timeCS", typeof(TimeCSPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("usesTemporalCS", typeof(TemporalCSPropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        public TemporalDatumPropertyType temporalDatum {
            get {
                return this.temporalDatumField;
            }
            set {
                this.temporalDatumField = value;
            }
        }
    }
}
