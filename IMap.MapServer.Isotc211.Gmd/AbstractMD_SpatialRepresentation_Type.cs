using EMap.MapServer.Isotc211.Gco;

namespace EMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_VectorSpatialRepresentation_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_GridSpatialRepresentation_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georectified_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Georeferenceable_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public abstract partial class AbstractMD_SpatialRepresentation_Type : AbstractObject_Type {
    }
}
