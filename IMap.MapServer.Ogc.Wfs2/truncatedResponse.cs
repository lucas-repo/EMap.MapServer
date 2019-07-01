using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class truncatedResponse {
        
        private ExceptionReport exceptionReportField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ows/1.1")]
        public ExceptionReport ExceptionReport {
            get {
                return this.exceptionReportField;
            }
            set {
                this.exceptionReportField = value;
            }
        }
    }
}
