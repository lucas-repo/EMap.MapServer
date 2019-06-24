namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionToPreferredUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivationUnitTermType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("unitOfMeasure", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class UnitOfMeasureType {
        
        private string uomField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}
