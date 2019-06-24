namespace SharpMapServer.Ogc.Gml3_2 {



    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType1))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(CoverageDescriptionType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractFeatureType : AbstractGMLType {
        
        private BoundingShapeType boundedByField;
        
        private LocationPropertyType locationField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public BoundingShapeType boundedBy {
            get {
                return this.boundedByField;
            }
            set {
                this.boundedByField = value;
            }
        }
        
        
        public LocationPropertyType location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
}
