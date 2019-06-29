namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureCollectionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractGMLType {
        
        private MetaDataPropertyType[] metaDataPropertyField;
        
        private StringOrRefType descriptionField;
        
        private CodeType1[] nameField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metaDataProperty")]
        public MetaDataPropertyType[] metaDataProperty {
            get {
                return this.metaDataPropertyField;
            }
            set {
                this.metaDataPropertyField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public CodeType1[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
