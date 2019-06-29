namespace IMap.MapServer.Ogc.Gml3_2 { 

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoverageType1))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(CoverageDescriptionType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractGMLType {
        
        private MetaDataPropertyType[] metaDataPropertyField;
        
        private StringOrRefType descriptionField;
        
        private ReferenceType descriptionReferenceField;
        
        private CodeWithAuthorityType identifierField;
        
        private CodeType[] nameField;
        
        private string idField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("metaDataProperty")]
        public MetaDataPropertyType[] metaDataProperty {
            get {
                return this.metaDataPropertyField;
            }
            set {
                this.metaDataPropertyField = value;
            }
        }
        
        
        public StringOrRefType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        
        public ReferenceType descriptionReference {
            get {
                return this.descriptionReferenceField;
            }
            set {
                this.descriptionReferenceField = value;
            }
        }
        
        
        public CodeWithAuthorityType identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public CodeType[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
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
