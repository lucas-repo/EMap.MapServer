namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("UnitDefinition", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class UnitDefinitionType : DefinitionType {
        
        private StringOrRefType quantityTypeField;
        
        private ReferenceType quantityTypeReferenceField;
        
        private CodeType catalogSymbolField;
        
        
        public StringOrRefType quantityType {
            get {
                return this.quantityTypeField;
            }
            set {
                this.quantityTypeField = value;
            }
        }
        
        
        public ReferenceType quantityTypeReference {
            get {
                return this.quantityTypeReferenceField;
            }
            set {
                this.quantityTypeReferenceField = value;
            }
        }
        
        
        public CodeType catalogSymbol {
            get {
                return this.catalogSymbolField;
            }
            set {
                this.catalogSymbolField = value;
            }
        }
    }
}
