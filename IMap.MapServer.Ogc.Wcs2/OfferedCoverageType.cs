using IMap.MapServer.Ogc.Gmlcov;

namespace IMap.MapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("OfferedCoverage", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class OfferedCoverageType {
        
        private AbstractCoverageType1 abstractCoverageField;
        
        private ServiceParametersType serviceParametersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gmlcov/1.0")]
        public AbstractCoverageType1 AbstractCoverage {
            get {
                return this.abstractCoverageField;
            }
            set {
                this.abstractCoverageField = value;
            }
        }
        
        
        public ServiceParametersType ServiceParameters {
            get {
                return this.serviceParametersField;
            }
            set {
                this.serviceParametersField = value;
            }
        }
    }
}
