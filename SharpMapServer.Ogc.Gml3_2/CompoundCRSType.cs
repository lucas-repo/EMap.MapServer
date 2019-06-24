namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CompoundCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class CompoundCRSType : AbstractCRSType {
        
        private SingleCRSPropertyType[] componentReferenceSystemField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        [System.Xml.Serialization.XmlElementAttribute("componentReferenceSystem")]
        public SingleCRSPropertyType[] componentReferenceSystem {
            get {
                return this.componentReferenceSystemField;
            }
            set {
                this.componentReferenceSystemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
