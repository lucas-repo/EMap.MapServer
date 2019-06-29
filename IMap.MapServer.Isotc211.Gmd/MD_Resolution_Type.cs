using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Resolution", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Resolution_Type {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("distance", typeof(Distance_PropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("equivalentScale", typeof(MD_RepresentativeFraction_PropertyType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
