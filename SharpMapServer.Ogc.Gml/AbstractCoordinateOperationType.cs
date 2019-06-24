namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateOperationType : AbstractCoordinateOperationBaseType {
        
        private IdentifierType[] coordinateOperationIDField;
        
        private StringOrRefType remarksField;
        
        private string operationVersionField;
        
        private ExtentType validAreaField;
        
        private string scopeField;
        
        private AbstractPositionalAccuracyType[] _positionalAccuracyField;
        
        private CRSRefType sourceCRSField;
        
        private CRSRefType targetCRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinateOperationID")]
        public IdentifierType[] coordinateOperationID {
            get {
                return this.coordinateOperationIDField;
            }
            set {
                this.coordinateOperationIDField = value;
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
        public string operationVersion {
            get {
                return this.operationVersionField;
            }
            set {
                this.operationVersionField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_positionalAccuracy")]
        public AbstractPositionalAccuracyType[] _positionalAccuracy {
            get {
                return this._positionalAccuracyField;
            }
            set {
                this._positionalAccuracyField = value;
            }
        }
        
        /// <remarks/>
        public CRSRefType sourceCRS {
            get {
                return this.sourceCRSField;
            }
            set {
                this.sourceCRSField = value;
            }
        }
        
        /// <remarks/>
        public CRSRefType targetCRS {
            get {
                return this.targetCRSField;
            }
            set {
                this.targetCRSField = value;
            }
        }
    }
}
