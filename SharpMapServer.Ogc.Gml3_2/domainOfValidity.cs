using SharpMapServer.Isotc211.Gmd;

namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class domainOfValidity {
        
        private EX_Extent_Type eX_ExtentField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
        public EX_Extent_Type EX_Extent {
            get {
                return this.eX_ExtentField;
            }
            set {
                this.eX_ExtentField = value;
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
