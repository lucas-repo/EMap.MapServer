namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("conversionToPreferredUnit", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class ConversionToPreferredUnitType : UnitOfMeasureType {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("factor", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("formula", typeof(FormulaType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
