namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ConventionalUnit", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ConventionalUnitType : UnitDefinitionType {
        
        private ConversionToPreferredUnitType itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        private DerivationUnitTermType[] derivationUnitTermField;
        
        
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
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        
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
