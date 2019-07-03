using EMap.MapServer.Ogc.Fes2;

namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Update", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class UpdateType : AbstractTransactionActionType {
        
        private PropertyType[] propertyField;
        
        private FilterType filterField;
        
        private System.Xml.XmlQualifiedName typeNameField;
        
        private string inputFormatField;
        
        private string srsNameField;
        
        public UpdateType() {
            this.inputFormatField = "application/gml+xml; version=3.2";
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public PropertyType[] Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
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
        public System.Xml.XmlQualifiedName typeName {
            get {
                return this.typeNameField;
            }
            set {
                this.typeNameField = value;
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
