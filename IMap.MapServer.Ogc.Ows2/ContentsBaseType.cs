namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentsType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    public partial class ContentsBaseType {
        
        private DatasetDescriptionSummaryBaseType[] datasetDescriptionSummaryField;
        
        private MetadataType[] otherSourceField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public DatasetDescriptionSummaryBaseType[] DatasetDescriptionSummary {
            get {
                return this.datasetDescriptionSummaryField;
            }
            set {
                this.datasetDescriptionSummaryField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("OtherSource")]
        public MetadataType[] OtherSource {
            get {
                return this.otherSourceField;
            }
            set {
                this.otherSourceField = value;
            }
        }
    }
}
