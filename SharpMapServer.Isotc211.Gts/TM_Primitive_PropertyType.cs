using SharpMapServer.Ogc.Gml;

namespace SharpMapServer.Isotc211.Gts {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gts")]
    public partial class TM_Primitive_PropertyType {
        
        private AbstractTimePrimitiveType abstractTimePrimitiveField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractTimePrimitiveType AbstractTimePrimitive {
            get {
                return this.abstractTimePrimitiveField;
            }
            set {
                this.abstractTimePrimitiveField = value;
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
