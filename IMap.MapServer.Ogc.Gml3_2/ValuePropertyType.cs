namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("valueProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ValuePropertyType {
        
        private object abstractValueField;
        
        private AbstractGeometryType abstractGeometryField;
        
        private AbstractTimeObjectType abstractTimeObjectField;
        
        private string nullField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        private bool ownsField;
        
        public ValuePropertyType() {
            this.ownsField = false;
        }
        
        
        public object AbstractValue {
            get {
                return this.abstractValueField;
            }
            set {
                this.abstractValueField = value;
            }
        }
        
        
        public AbstractGeometryType AbstractGeometry {
            get {
                return this.abstractGeometryField;
            }
            set {
                this.abstractGeometryField = value;
            }
        }
        
        
        public AbstractTimeObjectType AbstractTimeObject {
            get {
                return this.abstractTimeObjectField;
            }
            set {
                this.abstractTimeObjectField = value;
            }
        }
        
        
        public string Null {
            get {
                return this.nullField;
            }
            set {
                this.nullField = value;
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
    }
}
