using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_CoverageDescription_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ImageDescription_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_FeatureCatalogueDescription_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public abstract partial class AbstractMD_ContentInformation_Type : AbstractObject_Type {
    }
}
