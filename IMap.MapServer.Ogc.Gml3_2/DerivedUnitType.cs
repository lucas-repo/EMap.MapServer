namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedUnit", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DerivedUnitType : UnitDefinitionType {
        
        private DerivationUnitTermType[] derivationUnitTermField;
        
        
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
