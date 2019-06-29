using IMap.MapServer.Isotc211.Gco;

namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_ImageDescription_Type))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_CoverageDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class MD_CoverageDescription_Type : AbstractMD_ContentInformation_Type {
        
        private RecordType_PropertyType attributeDescriptionField;
        
        private MD_CoverageContentTypeCode_PropertyType contentTypeField;
        
        private MD_RangeDimension_PropertyType[] dimensionField;
        
        
        public RecordType_PropertyType attributeDescription {
            get {
                return this.attributeDescriptionField;
            }
            set {
                this.attributeDescriptionField = value;
            }
        }
        
        
        public MD_CoverageContentTypeCode_PropertyType contentType {
            get {
                return this.contentTypeField;
            }
            set {
                this.contentTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("dimension")]
        public MD_RangeDimension_PropertyType[] dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
    }
}
