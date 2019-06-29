namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class Extended_CapabilitiesType {
        
        private ExtensionOperatorType[] additionalOperatorsField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Operator", IsNullable=false)]
        public ExtensionOperatorType[] AdditionalOperators {
            get {
                return this.additionalOperatorsField;
            }
            set {
                this.additionalOperatorsField = value;
            }
        }
    }
}
