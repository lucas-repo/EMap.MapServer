namespace EMap.MapServer.Ogc.Gml3_2 {



    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType1))]

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractCoverageType : AbstractFeatureType {
        
        private DomainSetType domainSetField;
        
        private RangeSetType rangeSetField;
        
        
        public DomainSetType domainSet {
            get {
                return this.domainSetField;
            }
            set {
                this.domainSetField = value;
            }
        }
        
        
        public RangeSetType rangeSet {
            get {
                return this.rangeSetField;
            }
            set {
                this.rangeSetField = value;
            }
        }
    }
}
