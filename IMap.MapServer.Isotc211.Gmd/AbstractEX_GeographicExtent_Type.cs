using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_GeographicDescription_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_GeographicBoundingBox_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_BoundingPolygon_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public abstract partial class AbstractEX_GeographicExtent_Type : AbstractObject_Type {
        
        private Boolean_PropertyType extentTypeCodeField;
        
        
        public Boolean_PropertyType extentTypeCode {
            get {
                return this.extentTypeCodeField;
            }
            set {
                this.extentTypeCodeField = value;
            }
        }
    }
}
