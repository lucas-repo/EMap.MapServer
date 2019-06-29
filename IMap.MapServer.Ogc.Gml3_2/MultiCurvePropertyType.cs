namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("multiCenterLineOf", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiCurvePropertyType {
        
        private MultiCurveType multiCurveField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        private bool ownsField;
        
        public MultiCurvePropertyType() {
            this.ownsField = false;
        }
        
        
        public MultiCurveType MultiCurve {
            get {
                return this.multiCurveField;
            }
            set {
                this.multiCurveField = value;
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
