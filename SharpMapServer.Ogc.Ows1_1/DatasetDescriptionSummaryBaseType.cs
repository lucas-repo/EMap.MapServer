namespace SharpMapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("DatasetDescriptionSummary", Namespace="http://www.opengis.net/ows/1.1", IsNullable=false)]
    public partial class DatasetDescriptionSummaryBaseType : DescriptionType {
        
        private WGS84BoundingBoxType[] wGS84BoundingBoxField;
        
        private CodeType identifierField;
        
        private BoundingBoxType[] boundingBoxField;
        
        private MetadataType[] metadataField;
        
        private DatasetDescriptionSummaryBaseType[] datasetDescriptionSummaryField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox")]
        public WGS84BoundingBoxType[] WGS84BoundingBox {
            get {
                return this.wGS84BoundingBoxField;
            }
            set {
                this.wGS84BoundingBoxField = value;
            }
        }
        
        
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public BoundingBoxType[] BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public DatasetDescriptionSummaryBaseType[] DatasetDescriptionSummary {
            get {
                return this.datasetDescriptionSummaryField;
            }
            set {
                this.datasetDescriptionSummaryField = value;
            }
        }
    }
}
