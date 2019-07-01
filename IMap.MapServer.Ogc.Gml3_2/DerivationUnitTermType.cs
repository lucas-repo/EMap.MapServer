namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("derivationUnitTerm", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DerivationUnitTermType : UnitOfMeasureType {
        
        private string exponentField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string exponent {
            get {
                return this.exponentField;
            }
            set {
                this.exponentField = value;
            }
        }
    }
}
