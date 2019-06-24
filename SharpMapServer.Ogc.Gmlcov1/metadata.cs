using SharpMapServer.Ogc.Gml3_2;

namespace SharpMapServer.Ogc.Gmlcov {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gmlcov/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class metadata : AbstractMetadataPropertyType {
        
        private ExtensionType1 extensionField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        public ExtensionType1 Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
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
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
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
