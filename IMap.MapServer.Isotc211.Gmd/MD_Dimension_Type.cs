using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Dimension", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Dimension_Type : AbstractObject_Type {
        
        private MD_DimensionNameTypeCode_PropertyType dimensionNameField;
        
        private Integer_PropertyType dimensionSizeField;
        
        private Measure_PropertyType resolutionField;
        
        
        public MD_DimensionNameTypeCode_PropertyType dimensionName {
            get {
                return this.dimensionNameField;
            }
            set {
                this.dimensionNameField = value;
            }
        }
        
        
        public Integer_PropertyType dimensionSize {
            get {
                return this.dimensionSizeField;
            }
            set {
                this.dimensionSizeField = value;
            }
        }
        
        
        public Measure_PropertyType resolution {
            get {
                return this.resolutionField;
            }
            set {
                this.resolutionField = value;
            }
        }
    }
}
