namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class SpatialOperatorType {
        
        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable=false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands {
            get {
                return this.geometryOperandsField;
            }
            set {
                this.geometryOperandsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
