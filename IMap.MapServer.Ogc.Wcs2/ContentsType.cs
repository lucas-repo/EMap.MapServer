using IMap.MapServer.Ogc.Ows2;

namespace IMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Contents", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class ContentsType : ContentsBaseType {
        
        private CoverageSummaryType[] coverageSummaryField;
        
        private ExtensionType extensionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("CoverageSummary")]
        public CoverageSummaryType[] CoverageSummary {
            get {
                return this.coverageSummaryField;
            }
            set {
                this.coverageSummaryField = value;
            }
        }
        
        
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
}
