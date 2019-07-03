using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_ImageDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_ImageDescription_Type : MD_CoverageDescription_Type {
        
        private Real_PropertyType illuminationElevationAngleField;
        
        private Real_PropertyType illuminationAzimuthAngleField;
        
        private MD_ImagingConditionCode_PropertyType imagingConditionField;
        
        private MD_Identifier_PropertyType imageQualityCodeField;
        
        private Real_PropertyType cloudCoverPercentageField;
        
        private MD_Identifier_PropertyType processingLevelCodeField;
        
        private Integer_PropertyType compressionGenerationQuantityField;
        
        private Boolean_PropertyType triangulationIndicatorField;
        
        private Boolean_PropertyType radiometricCalibrationDataAvailabilityField;
        
        private Boolean_PropertyType cameraCalibrationInformationAvailabilityField;
        
        private Boolean_PropertyType filmDistortionInformationAvailabilityField;
        
        private Boolean_PropertyType lensDistortionInformationAvailabilityField;
        
        
        public Real_PropertyType illuminationElevationAngle {
            get {
                return this.illuminationElevationAngleField;
            }
            set {
                this.illuminationElevationAngleField = value;
            }
        }
        
        
        public Real_PropertyType illuminationAzimuthAngle {
            get {
                return this.illuminationAzimuthAngleField;
            }
            set {
                this.illuminationAzimuthAngleField = value;
            }
        }
        
        
        public MD_ImagingConditionCode_PropertyType imagingCondition {
            get {
                return this.imagingConditionField;
            }
            set {
                this.imagingConditionField = value;
            }
        }
        
        
        public MD_Identifier_PropertyType imageQualityCode {
            get {
                return this.imageQualityCodeField;
            }
            set {
                this.imageQualityCodeField = value;
            }
        }
        
        
        public Real_PropertyType cloudCoverPercentage {
            get {
                return this.cloudCoverPercentageField;
            }
            set {
                this.cloudCoverPercentageField = value;
            }
        }
        
        
        public MD_Identifier_PropertyType processingLevelCode {
            get {
                return this.processingLevelCodeField;
            }
            set {
                this.processingLevelCodeField = value;
            }
        }
        
        
        public Integer_PropertyType compressionGenerationQuantity {
            get {
                return this.compressionGenerationQuantityField;
            }
            set {
                this.compressionGenerationQuantityField = value;
            }
        }
        
        
        public Boolean_PropertyType triangulationIndicator {
            get {
                return this.triangulationIndicatorField;
            }
            set {
                this.triangulationIndicatorField = value;
            }
        }
        
        
        public Boolean_PropertyType radiometricCalibrationDataAvailability {
            get {
                return this.radiometricCalibrationDataAvailabilityField;
            }
            set {
                this.radiometricCalibrationDataAvailabilityField = value;
            }
        }
        
        
        public Boolean_PropertyType cameraCalibrationInformationAvailability {
            get {
                return this.cameraCalibrationInformationAvailabilityField;
            }
            set {
                this.cameraCalibrationInformationAvailabilityField = value;
            }
        }
        
        
        public Boolean_PropertyType filmDistortionInformationAvailability {
            get {
                return this.filmDistortionInformationAvailabilityField;
            }
            set {
                this.filmDistortionInformationAvailabilityField = value;
            }
        }
        
        
        public Boolean_PropertyType lensDistortionInformationAvailability {
            get {
                return this.lensDistortionInformationAvailabilityField;
            }
            set {
                this.lensDistortionInformationAvailabilityField = value;
            }
        }
    }
}
