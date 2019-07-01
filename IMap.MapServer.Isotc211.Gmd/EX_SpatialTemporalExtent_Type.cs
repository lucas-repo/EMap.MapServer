namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_SpatialTemporalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_SpatialTemporalExtent_Type : EX_TemporalExtent_Type {
        
        private EX_GeographicExtent_PropertyType[] spatialExtentField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("spatialExtent")]
        public EX_GeographicExtent_PropertyType[] spatialExtent {
            get {
                return this.spatialExtentField;
            }
            set {
                this.spatialExtentField = value;
            }
        }
    }
}
