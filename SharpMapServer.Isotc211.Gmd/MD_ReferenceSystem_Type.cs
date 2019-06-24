using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_ReferenceSystem", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_ReferenceSystem_Type : AbstractObject_Type {
        
        private RS_Identifier_PropertyType referenceSystemIdentifierField;
        
        
        public RS_Identifier_PropertyType referenceSystemIdentifier {
            get {
                return this.referenceSystemIdentifierField;
            }
            set {
                this.referenceSystemIdentifierField = value;
            }
        }
    }
}
