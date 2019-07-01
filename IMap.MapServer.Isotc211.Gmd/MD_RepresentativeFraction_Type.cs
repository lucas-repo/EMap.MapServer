using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_RepresentativeFraction", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_RepresentativeFraction_Type : AbstractObject_Type {
        
        private Integer_PropertyType denominatorField;
        
        
        public Integer_PropertyType denominator {
            get {
                return this.denominatorField;
            }
            set {
                this.denominatorField = value;
            }
        }
    }
}
