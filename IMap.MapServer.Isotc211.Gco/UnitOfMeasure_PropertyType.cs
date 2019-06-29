using IMap.MapServer.Ogc.Gml;

namespace IMap.MapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    public partial class UnitOfMeasure_PropertyType {
        
        private UnitDefinitionType unitDefinitionField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public UnitDefinitionType UnitDefinition {
            get {
                return this.unitDefinitionField;
            }
            set {
                this.unitDefinitionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuidref {
            get {
                return this.uuidrefField;
            }
            set {
                this.uuidrefField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
