namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("BaseUnit", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class BaseUnitType : UnitDefinitionType {
        
        private ReferenceType unitsSystemField;
        
        
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
