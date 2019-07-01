namespace EMap.MapServer.Ogc.Gmlcov {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gmlcov/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("referenceableGridProperty", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class ReferenceableGridPropertyType {
        
        private AbstractReferenceableGridType abstractReferenceableGridField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        private bool ownsField;
        
        public ReferenceableGridPropertyType() {
            this.ownsField = false;
        }
        
        
        public AbstractReferenceableGridType AbstractReferenceableGrid {
            get {
                return this.abstractReferenceableGridField;
            }
            set {
                this.abstractReferenceableGridField = value;
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
