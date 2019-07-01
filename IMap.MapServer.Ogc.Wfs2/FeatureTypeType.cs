using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    public partial class FeatureTypeType {
        
        private System.Xml.XmlQualifiedName nameField;
        
        private Title[] titleField;
        
        private Abstract[] abstractField;
        
        private KeywordsType[] keywordsField;
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private OutputFormatListType outputFormatsField;
        
        private WGS84BoundingBoxType[] wGS84BoundingBoxField;
        
        private MetadataURLType[] metadataURLField;
        
        private ElementType[] extendedDescriptionField;
        
        
        public System.Xml.XmlQualifiedName Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Title[] Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Abstract[] Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Keywords", Namespace="http://www.opengis.net/ows/1.1")]
        public KeywordsType[] Keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("DefaultCRS", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("NoCRS", typeof(FeatureTypeTypeNoCRS))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCRS", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        
        public OutputFormatListType OutputFormats {
            get {
                return this.outputFormatsField;
            }
            set {
                this.outputFormatsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox", Namespace="http://www.opengis.net/ows/1.1")]
        public WGS84BoundingBoxType[] WGS84BoundingBox {
            get {
                return this.wGS84BoundingBoxField;
            }
            set {
                this.wGS84BoundingBoxField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("MetadataURL")]
        public MetadataURLType[] MetadataURL {
            get {
                return this.metadataURLField;
            }
            set {
                this.metadataURLField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Element", IsNullable=false)]
        public ElementType[] ExtendedDescription {
            get {
                return this.extendedDescriptionField;
            }
            set {
                this.extendedDescriptionField = value;
            }
        }
    }
}
