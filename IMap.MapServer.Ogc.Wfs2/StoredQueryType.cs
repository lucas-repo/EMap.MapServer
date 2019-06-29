using IMap.MapServer.Ogc.Fes2;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("StoredQuery", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class StoredQueryType : AbstractQueryExpressionType {
        
        private ParameterType[] parameterField;
        
        private string idField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
