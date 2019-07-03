using EMap.MapServer.Isotc211.Gmd;

namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class formulaCitation {
        
        private CI_Citation_Type cI_CitationField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
        public CI_Citation_Type CI_Citation {
            get {
                return this.cI_CitationField;
            }
            set {
                this.cI_CitationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
