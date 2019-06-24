namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ConventionalUnit", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ConventionalUnitType : UnitDefinitionType {
        
        private ConversionToPreferredUnitType itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private DerivationUnitTermType[] derivationUnitTermField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conversionToPreferredUnit", typeof(ConversionToPreferredUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("roughConversionToPreferredUnit", typeof(ConversionToPreferredUnitType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ConversionToPreferredUnitType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
        public DerivationUnitTermType[] derivationUnitTerm {
            get {
                return this.derivationUnitTermField;
            }
            set {
                this.derivationUnitTermField = value;
            }
        }
    }
}
