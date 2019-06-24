using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_PortrayalCatalogueReference", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_PortrayalCatalogueReference_Type : AbstractObject_Type {
        
        private CI_Citation_PropertyType[] portrayalCatalogueCitationField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("portrayalCatalogueCitation")]
        public CI_Citation_PropertyType[] portrayalCatalogueCitation {
            get {
                return this.portrayalCatalogueCitationField;
            }
            set {
                this.portrayalCatalogueCitationField = value;
            }
        }
    }
}
