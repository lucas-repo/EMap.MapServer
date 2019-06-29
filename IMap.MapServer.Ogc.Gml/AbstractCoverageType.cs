namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDiscreteCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractCoverageType : AbstractFeatureType {
        
        private DomainSetType domainSetField;
        
        private RangeSetType rangeSetField;
        
        private string dimensionField;
        
        /// <remarks/>
        public DomainSetType domainSet {
            get {
                return this.domainSetField;
            }
            set {
                this.domainSetField = value;
            }
        }
        
        /// <remarks/>
        public RangeSetType rangeSet {
            get {
                return this.rangeSetField;
            }
            set {
                this.rangeSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
    }
}
