using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Band_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_RangeDimension", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_RangeDimension_Type : AbstractObject_Type {
        
        private MemberName_PropertyType sequenceIdentifierField;
        
        private CharacterString_PropertyType descriptorField;
        
        
        public MemberName_PropertyType sequenceIdentifier {
            get {
                return this.sequenceIdentifierField;
            }
            set {
                this.sequenceIdentifierField = value;
            }
        }
        
        
        public CharacterString_PropertyType descriptor {
            get {
                return this.descriptorField;
            }
            set {
                this.descriptorField = value;
            }
        }
    }
}
