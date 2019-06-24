namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObliqueCartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AffineCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolarCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractCoordinateSystemType : IdentifiedObjectType {
        
        private CoordinateSystemAxisPropertyType[] axisField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        [System.Xml.Serialization.XmlElementAttribute("axis")]
        public CoordinateSystemAxisPropertyType[] axis {
            get {
                return this.axisField;
            }
            set {
                this.axisField = value;
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
