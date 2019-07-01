namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("File", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class FileType {
        
        private RangeParametersType rangeParametersField;
        
        private string fileNameField;
        
        private FileValueModelType fileStructureField;
        
        private string mimeTypeField;
        
        private string compressionField;
        
        /// <remarks/>
        public RangeParametersType rangeParameters {
            get {
                return this.rangeParametersField;
            }
            set {
                this.rangeParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        public FileValueModelType fileStructure {
            get {
                return this.fileStructureField;
            }
            set {
                this.fileStructureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string mimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string compression {
            get {
                return this.compressionField;
            }
            set {
                this.compressionField = value;
            }
        }
    }
}
