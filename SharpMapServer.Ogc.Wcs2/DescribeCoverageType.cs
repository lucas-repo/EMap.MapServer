namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeCoverage", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class DescribeCoverageType : RequestBaseType {
        
        private string[] coverageIdField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("CoverageId", DataType="NCName")]
        public string[] CoverageId {
            get {
                return this.coverageIdField;
            }
            set {
                this.coverageIdField = value;
            }
        }
    }
}
