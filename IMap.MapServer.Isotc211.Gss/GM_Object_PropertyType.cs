using IMap.MapServer.Ogc.Gml;

namespace IMap.MapServer.Isotc211.Gss {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gss")]
    public partial class GM_Object_PropertyType {
        
        private AbstractGeometryType abstractGeometryField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractGeometryType AbstractGeometry {
            get {
                return this.abstractGeometryField;
            }
            set {
                this.abstractGeometryField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.isotc211.org/2005/gco")]
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
