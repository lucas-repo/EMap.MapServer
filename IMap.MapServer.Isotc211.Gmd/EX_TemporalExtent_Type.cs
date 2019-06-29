using IMap.MapServer.Isotc211.Gco;
using IMap.MapServer.Isotc211.Gts;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_SpatialTemporalExtent_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_TemporalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_TemporalExtent_Type : AbstractObject_Type {
        
        private TM_Primitive_PropertyType extentField;
        
        
        public TM_Primitive_PropertyType extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
    }
}
