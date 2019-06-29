using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georectified_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georeferenceable_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_GridSpatialRepresentation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_GridSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type {
        
        private Integer_PropertyType numberOfDimensionsField;
        
        private MD_Dimension_PropertyType[] axisDimensionPropertiesField;
        
        private MD_CellGeometryCode_PropertyType cellGeometryField;
        
        private Boolean_PropertyType transformationParameterAvailabilityField;
        
        
        public Integer_PropertyType numberOfDimensions {
            get {
                return this.numberOfDimensionsField;
            }
            set {
                this.numberOfDimensionsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("axisDimensionProperties")]
        public MD_Dimension_PropertyType[] axisDimensionProperties {
            get {
                return this.axisDimensionPropertiesField;
            }
            set {
                this.axisDimensionPropertiesField = value;
            }
        }
        
        
        public MD_CellGeometryCode_PropertyType cellGeometry {
            get {
                return this.cellGeometryField;
            }
            set {
                this.cellGeometryField = value;
            }
        }
        
        
        public Boolean_PropertyType transformationParameterAvailability {
            get {
                return this.transformationParameterAvailabilityField;
            }
            set {
                this.transformationParameterAvailabilityField = value;
            }
        }
    }
}
