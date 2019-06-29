namespace IMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageOfferings", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CoverageOfferingsType {
        
        private ServiceMetadataType serviceMetadataField;
        
        private OfferedCoverageType[] offeredCoverageField;
        
        
        public ServiceMetadataType ServiceMetadata {
            get {
                return this.serviceMetadataField;
            }
            set {
                this.serviceMetadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("OfferedCoverage")]
        public OfferedCoverageType[] OfferedCoverage {
            get {
                return this.offeredCoverageField;
            }
            set {
                this.offeredCoverageField = value;
            }
        }
    }
}
