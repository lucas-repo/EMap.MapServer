namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveDomainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointDomainType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("domainSet", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DomainSetType {
        
        private AbstractGMLType itemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType))]
        [System.Xml.Serialization.XmlElementAttribute("_TimeObject", typeof(AbstractTimeObjectType))]
        public AbstractGMLType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
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
