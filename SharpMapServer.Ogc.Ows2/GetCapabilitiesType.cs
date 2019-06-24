namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(GetCapabilitiesType2))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class GetCapabilitiesType {
        
        private string[] acceptVersionsField;
        
        private string[] sectionsField;
        
        private string[] acceptFormatsField;
        
        private string[] acceptLanguagesField;
        
        private string updateSequenceField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Version", IsNullable=false)]
        public string[] AcceptVersions {
            get {
                return this.acceptVersionsField;
            }
            set {
                this.acceptVersionsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Section", IsNullable=false)]
        public string[] Sections {
            get {
                return this.sectionsField;
            }
            set {
                this.sectionsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputFormat", IsNullable=false)]
        public string[] AcceptFormats {
            get {
                return this.acceptFormatsField;
            }
            set {
                this.acceptFormatsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Language", DataType="language", IsNullable=false)]
        public string[] AcceptLanguages {
            get {
                return this.acceptLanguagesField;
            }
            set {
                this.acceptLanguagesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string updateSequence {
            get {
                return this.updateSequenceField;
            }
            set {
                this.updateSequenceField = value;
            }
        }
    }
}
