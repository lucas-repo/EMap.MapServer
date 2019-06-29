using IMap.MapServer.Ogc.Fes2;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Query", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class QueryType : AbstractAdhocQueryExpressionType {
        
        private string srsNameField;
        
        private string featureVersionField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string featureVersion {
            get {
                return this.featureVersionField;
            }
            set {
                this.featureVersionField = value;
            }
        }
    }
}
