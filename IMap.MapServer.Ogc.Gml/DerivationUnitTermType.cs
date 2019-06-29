namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("derivationUnitTerm", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DerivationUnitTermType : UnitOfMeasureType {
        
        private string exponentField;
        
        /// <remarks/>
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
