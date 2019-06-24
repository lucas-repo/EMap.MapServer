namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("BaseUnit", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class BaseUnitType : UnitDefinitionType {
        
        private ReferenceType unitsSystemField;
        
        /// <remarks/>
        public ReferenceType unitsSystem {
            get {
                return this.unitsSystemField;
            }
            set {
                this.unitsSystemField = value;
            }
        }
    }
}
