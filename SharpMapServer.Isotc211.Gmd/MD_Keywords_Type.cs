using SharpMapServer.Isotc211.Gco;

namespace SharpMapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Keywords", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_Keywords_Type : AbstractObject_Type {
        
        private CharacterString_PropertyType[] keywordField;
        
        private MD_KeywordTypeCode_PropertyType typeField;
        
        private CI_Citation_PropertyType thesaurusNameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("keyword")]
        public CharacterString_PropertyType[] keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }
        
        
        public MD_KeywordTypeCode_PropertyType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        
        public CI_Citation_PropertyType thesaurusName {
            get {
                return this.thesaurusNameField;
            }
            set {
                this.thesaurusNameField = value;
            }
        }
    }
}
