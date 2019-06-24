namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageDescriptions", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CoverageDescriptionsType {
        
        private CoverageDescriptionType[] coverageDescriptionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("CoverageDescription")]
        public CoverageDescriptionType[] CoverageDescription {
            get {
                return this.coverageDescriptionField;
            }
            set {
                this.coverageDescriptionField = value;
            }
        }
    }
}
