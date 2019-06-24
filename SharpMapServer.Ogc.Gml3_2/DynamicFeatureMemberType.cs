namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("dynamicMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DynamicFeatureMemberType : AbstractFeatureMemberType {
        
        private DynamicFeatureType[] dynamicFeatureField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("DynamicFeature")]
        public DynamicFeatureType[] DynamicFeature {
            get {
                return this.dynamicFeatureField;
            }
            set {
                this.dynamicFeatureField = value;
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
