using SharpMapServer.Ogc.Fes2;

namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Replace", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ReplaceType : AbstractTransactionActionType {
        
        private System.Xml.XmlElement anyField;
        
        private FilterType filterField;
        
        private string inputFormatField;
        
        private string srsNameField;
        
        public ReplaceType() {
            this.inputFormatField = "application/gml+xml; version=3.2";
        }
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/fes/2.0")]
        public FilterType Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string inputFormat {
            get {
                return this.inputFormatField;
            }
            set {
                this.inputFormatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string srsName {
            get {
                return this.srsNameField;
            }
            set {
                this.srsNameField = value;
            }
        }
    }
}
