using System.Xml.Linq;

namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractAdhocQueryExpressionType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(StoredQueryType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractQueryExpressionType {
        
        private string handleField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle {
            get {
                return this.handleField;
            }
            set {
                this.handleField = value;
            }
        }
    }
}
