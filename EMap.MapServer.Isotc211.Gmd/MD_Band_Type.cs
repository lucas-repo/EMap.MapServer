using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Band", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Band_Type : MD_RangeDimension_Type {
        
        private Real_PropertyType maxValueField;
        
        private Real_PropertyType minValueField;
        
        private UomLength_PropertyType unitsField;
        
        private Real_PropertyType peakResponseField;
        
        private Integer_PropertyType bitsPerValueField;
        
        private Integer_PropertyType toneGradationField;
        
        private Real_PropertyType scaleFactorField;
        
        private Real_PropertyType offsetField;
        
        
        public Real_PropertyType maxValue {
            get {
                return this.maxValueField;
            }
            set {
                this.maxValueField = value;
            }
        }
        
        
        public Real_PropertyType minValue {
            get {
                return this.minValueField;
            }
            set {
                this.minValueField = value;
            }
        }
        
        
        public UomLength_PropertyType units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        
        public Real_PropertyType peakResponse {
            get {
                return this.peakResponseField;
            }
            set {
                this.peakResponseField = value;
            }
        }
        
        
        public Integer_PropertyType bitsPerValue {
            get {
                return this.bitsPerValueField;
            }
            set {
                this.bitsPerValueField = value;
            }
        }
        
        
        public Integer_PropertyType toneGradation {
            get {
                return this.toneGradationField;
            }
            set {
                this.toneGradationField = value;
            }
        }
        
        
        public Real_PropertyType scaleFactor {
            get {
                return this.scaleFactorField;
            }
            set {
                this.scaleFactorField = value;
            }
        }
        
        
        public Real_PropertyType offset {
            get {
                return this.offsetField;
            }
            set {
                this.offsetField = value;
            }
        }
    }
}
