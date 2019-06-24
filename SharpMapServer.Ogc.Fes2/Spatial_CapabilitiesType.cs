namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class Spatial_CapabilitiesType {
        
        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;
        
        private SpatialOperatorType[] spatialOperatorsField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable=false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands {
            get {
                return this.geometryOperandsField;
            }
            set {
                this.geometryOperandsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SpatialOperator", IsNullable=false)]
        public SpatialOperatorType[] SpatialOperators {
            get {
                return this.spatialOperatorsField;
            }
            set {
                this.spatialOperatorsField = value;
            }
        }
    }
}
