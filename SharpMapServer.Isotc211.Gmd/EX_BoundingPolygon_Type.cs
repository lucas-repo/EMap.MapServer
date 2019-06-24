using SharpMapServer.Isotc211.Gss;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_BoundingPolygon", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_BoundingPolygon_Type : AbstractEX_GeographicExtent_Type {
        
        private GM_Object_PropertyType[] polygonField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("polygon")]
        public GM_Object_PropertyType[] polygon {
            get {
                return this.polygonField;
            }
            set {
                this.polygonField = value;
            }
        }
    }
}
