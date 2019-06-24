namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConventionalUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("UnitDefinition", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class UnitDefinitionType : DefinitionType {
        
        private StringOrRefType quantityTypeField;
        
        private CodeType1 catalogSymbolField;
        
        /// <remarks/>
        public StringOrRefType quantityType {
            get {
                return this.quantityTypeField;
            }
            set {
                this.quantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public CodeType1 catalogSymbol {
            get {
                return this.catalogSymbolField;
            }
            set {
                this.catalogSymbolField = value;
            }
        }
    }
}
