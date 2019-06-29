using IMap.MapServer.Ogc.Ows1_1;

namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class StoredQueryDescriptionType {
        
        private Title[] titleField;
        
        private Abstract[] abstractField;
        
        private MetadataType[] metadataField;
        
        private ParameterExpressionType[] parameterField;
        
        private QueryExpressionTextType[] queryExpressionTextField;
        
        private string idField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace="http://www.opengis.net/ows/1.1")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterExpressionType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("QueryExpressionText")]
        public QueryExpressionTextType[] QueryExpressionText {
            get {
                return this.queryExpressionTextField;
            }
            set {
                this.queryExpressionTextField = value;
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
