namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_VectorSpatialRepresentation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_VectorSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {
        
        private MD_TopologyLevelCode_PropertyType topologyLevelField;
        
        private MD_GeometricObjects_PropertyType[] geometricObjectsField;
        
        
        public MD_TopologyLevelCode_PropertyType topologyLevel {
            get {
                return this.topologyLevelField;
            }
            set {
                this.topologyLevelField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("geometricObjects")]
        public MD_GeometricObjects_PropertyType[] geometricObjects {
            get {
                return this.geometricObjectsField;
            }
            set {
                this.geometricObjectsField = value;
            }
        }
    }
}
