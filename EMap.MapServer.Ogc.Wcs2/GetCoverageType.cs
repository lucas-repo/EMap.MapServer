namespace EMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCoverage", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class GetCoverageType : RequestBaseType {
        
        private string coverageIdField;
        
        private DimensionSubsetType[] dimensionSubsetField;
        
        private string formatField;
        
        private string mediaTypeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string CoverageId {
            get {
                return this.coverageIdField;
            }
            set {
                this.coverageIdField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DimensionSubset")]
        public DimensionSubsetType[] DimensionSubset {
            get {
                return this.dimensionSubsetField;
            }
            set {
                this.dimensionSubsetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string mediaType {
            get {
                return this.mediaTypeField;
            }
            set {
                this.mediaTypeField = value;
            }
        }
    }
}
