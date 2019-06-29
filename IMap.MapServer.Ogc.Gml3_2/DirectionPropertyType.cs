namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("direction", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DirectionPropertyType {
        
        private object itemField;
        
        private bool ownsField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        public DirectionPropertyType() {
            this.ownsField = false;
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("CompassPoint", typeof(CompassPointEnumeration))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionDescription", typeof(DirectionDescriptionType))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionKeyword", typeof(CodeType))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionString", typeof(StringOrRefType))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionVector", typeof(DirectionVectorType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
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
