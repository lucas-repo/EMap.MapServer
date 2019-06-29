namespace IMap.MapServer.Ogc.Wms {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wms", IsNullable=false)]
    public partial class Layer {
        
        private string nameField;
        
        private string titleField;
        
        private string abstractField;
        
        private Keyword[] keywordListField;
        
        private string[] cRSField;
        
        private EX_GeographicBoundingBox eX_GeographicBoundingBoxField;
        
        private BoundingBox[] boundingBoxField;
        
        private Dimension[] dimensionField;
        
        private Attribution attributionField;
        
        private AuthorityURL[] authorityURLField;
        
        private Identifier[] identifierField;
        
        private MetadataURL[] metadataURLField;
        
        private DataURL[] dataURLField;
        
        private FeatureListURL[] featureListURLField;
        
        private Style[] styleField;
        
        private double minScaleDenominatorField;
        
        private bool minScaleDenominatorFieldSpecified;
        
        private double maxScaleDenominatorField;
        
        private bool maxScaleDenominatorFieldSpecified;
        
        private Layer[] layer1Field;
        
        private bool queryableField;
        
        private string cascadedField;
        
        private bool opaqueField;
        
        private bool noSubsetsField;
        
        private string fixedWidthField;
        
        private string fixedHeightField;
        
        public Layer() {
            this.queryableField = false;
            this.opaqueField = false;
            this.noSubsetsField = false;
        }
        
        
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        public string Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Keyword", IsNullable=false)]
        public Keyword[] KeywordList {
            get {
                return this.keywordListField;
            }
            set {
                this.keywordListField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("CRS")]
        public string[] CRS {
            get {
                return this.cRSField;
            }
            set {
                this.cRSField = value;
            }
        }
        
        
        public EX_GeographicBoundingBox EX_GeographicBoundingBox {
            get {
                return this.eX_GeographicBoundingBoxField;
            }
            set {
                this.eX_GeographicBoundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public BoundingBox[] BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public Dimension[] Dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
        
        
        public Attribution Attribution {
            get {
                return this.attributionField;
            }
            set {
                this.attributionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("AuthorityURL")]
        public AuthorityURL[] AuthorityURL {
            get {
                return this.authorityURLField;
            }
            set {
                this.authorityURLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public Identifier[] Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("MetadataURL")]
        public MetadataURL[] MetadataURL {
            get {
                return this.metadataURLField;
            }
            set {
                this.metadataURLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DataURL")]
        public DataURL[] DataURL {
            get {
                return this.dataURLField;
            }
            set {
                this.dataURLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("FeatureListURL")]
        public FeatureListURL[] FeatureListURL {
            get {
                return this.featureListURLField;
            }
            set {
                this.featureListURLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Style")]
        public Style[] Style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        
        public double MinScaleDenominator {
            get {
                return this.minScaleDenominatorField;
            }
            set {
                this.minScaleDenominatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinScaleDenominatorSpecified {
            get {
                return this.minScaleDenominatorFieldSpecified;
            }
            set {
                this.minScaleDenominatorFieldSpecified = value;
            }
        }
        
        
        public double MaxScaleDenominator {
            get {
                return this.maxScaleDenominatorField;
            }
            set {
                this.maxScaleDenominatorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxScaleDenominatorSpecified {
            get {
                return this.maxScaleDenominatorFieldSpecified;
            }
            set {
                this.maxScaleDenominatorFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Layer")]
        public Layer[] Layer1 {
            get {
                return this.layer1Field;
            }
            set {
                this.layer1Field = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool queryable {
            get {
                return this.queryableField;
            }
            set {
                this.queryableField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string cascaded {
            get {
                return this.cascadedField;
            }
            set {
                this.cascadedField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool opaque {
            get {
                return this.opaqueField;
            }
            set {
                this.opaqueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool noSubsets {
            get {
                return this.noSubsetsField;
            }
            set {
                this.noSubsetsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string fixedWidth {
            get {
                return this.fixedWidthField;
            }
            set {
                this.fixedWidthField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string fixedHeight {
            get {
                return this.fixedHeightField;
            }
            set {
                this.fixedHeightField = value;
            }
        }
    }
}
