namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractDatumType : AbstractDatumBaseType {
        
        private IdentifierType[] datumIDField;
        
        private StringOrRefType remarksField;
        
        private CodeType1 anchorPointField;
        
        private System.DateTime realizationEpochField;
        
        private bool realizationEpochFieldSpecified;
        
        private ExtentType validAreaField;
        
        private string scopeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("datumID")]
        public IdentifierType[] datumID {
            get {
                return this.datumIDField;
            }
            set {
                this.datumIDField = value;
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
        public CodeType1 anchorPoint {
            get {
                return this.anchorPointField;
            }
            set {
                this.anchorPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime realizationEpoch {
            get {
                return this.realizationEpochField;
            }
            set {
                this.realizationEpochField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool realizationEpochSpecified {
            get {
                return this.realizationEpochFieldSpecified;
            }
            set {
                this.realizationEpochFieldSpecified = value;
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
