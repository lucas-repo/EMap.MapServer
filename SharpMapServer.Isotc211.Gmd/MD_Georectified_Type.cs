using SharpMapServer.Isotc211.Gco;
using SharpMapServer.Isotc211.Gss;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Georectified", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Georectified_Type : MD_GridSpatialRepresentation_Type {
        
        private Boolean_PropertyType checkPointAvailabilityField;
        
        private CharacterString_PropertyType checkPointDescriptionField;
        
        private GM_Point_PropertyType[] cornerPointsField;
        
        private GM_Point_PropertyType centerPointField;
        
        private MD_PixelOrientationCode_PropertyType pointInPixelField;
        
        private CharacterString_PropertyType transformationDimensionDescriptionField;
        
        private CharacterString_PropertyType[] transformationDimensionMappingField;
        
        
        public Boolean_PropertyType checkPointAvailability {
            get {
                return this.checkPointAvailabilityField;
            }
            set {
                this.checkPointAvailabilityField = value;
            }
        }
        
        
        public CharacterString_PropertyType checkPointDescription {
            get {
                return this.checkPointDescriptionField;
            }
            set {
                this.checkPointDescriptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("cornerPoints")]
        public GM_Point_PropertyType[] cornerPoints {
            get {
                return this.cornerPointsField;
            }
            set {
                this.cornerPointsField = value;
            }
        }
        
        
        public GM_Point_PropertyType centerPoint {
            get {
                return this.centerPointField;
            }
            set {
                this.centerPointField = value;
            }
        }
        
        
        public MD_PixelOrientationCode_PropertyType pointInPixel {
            get {
                return this.pointInPixelField;
            }
            set {
                this.pointInPixelField = value;
            }
        }
        
        
        public CharacterString_PropertyType transformationDimensionDescription {
            get {
                return this.transformationDimensionDescriptionField;
            }
            set {
                this.transformationDimensionDescriptionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("transformationDimensionMapping")]
        public CharacterString_PropertyType[] transformationDimensionMapping {
            get {
                return this.transformationDimensionMappingField;
            }
            set {
                this.transformationDimensionMappingField = value;
            }
        }
    }
}
