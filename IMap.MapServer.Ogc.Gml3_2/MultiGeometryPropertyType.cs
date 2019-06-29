namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("multiGeometryProperty", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiGeometryPropertyType {
        
        private AbstractGeometricAggregateType abstractGeometricAggregateField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        private bool ownsField;
        
        public MultiGeometryPropertyType() {
            this.ownsField = false;
        }
        
        
        public AbstractGeometricAggregateType AbstractGeometricAggregate {
            get {
                return this.abstractGeometricAggregateField;
            }
            set {
                this.abstractGeometricAggregateField = value;
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
