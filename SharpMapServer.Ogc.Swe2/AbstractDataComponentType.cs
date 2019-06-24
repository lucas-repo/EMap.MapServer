namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public abstract partial class AbstractDataComponentType : AbstractSWEIdentifiableType {
        
        private bool updatableField;
        
        private bool updatableFieldSpecified;
        
        private bool optionalField;
        
        private string definitionField;
        
        public AbstractDataComponentType() {
            this.optionalField = false;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool updatable {
            get {
                return this.updatableField;
            }
            set {
                this.updatableField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updatableSpecified {
            get {
                return this.updatableFieldSpecified;
            }
            set {
                this.updatableFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool optional {
            get {
                return this.optionalField;
            }
            set {
                this.optionalField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
    }
}
