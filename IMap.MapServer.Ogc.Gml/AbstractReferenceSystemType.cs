namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractReferenceSystemType : AbstractReferenceSystemBaseType {
        
        private IdentifierType[] srsIDField;
        
        private StringOrRefType remarksField;
        
        private ExtentType validAreaField;
        
        private string scopeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("srsID")]
        public IdentifierType[] srsID {
            get {
                return this.srsIDField;
            }
            set {
                this.srsIDField = value;
            }
        }
        
        /// <remarks/>
        public StringOrRefType remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        public ExtentType validArea {
            get {
                return this.validAreaField;
            }
            set {
                this.validAreaField = value;
            }
        }
        
        /// <remarks/>
        public string scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
    }
}
