namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractCoordinateOperationType : IdentifiedObjectType {
        
        private domainOfValidity domainOfValidityField;
        
        private string[] scopeField;
        
        private string operationVersionField;
        
        private coordinateOperationAccuracy[] coordinateOperationAccuracyField;
        
        private CRSPropertyType sourceCRSField;
        
        private CRSPropertyType targetCRSField;
        
        
        public domainOfValidity domainOfValidity {
            get {
                return this.domainOfValidityField;
            }
            set {
                this.domainOfValidityField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("scope")]
        public string[] scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        
        public string operationVersion {
            get {
                return this.operationVersionField;
            }
            set {
                this.operationVersionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("coordinateOperationAccuracy")]
        public coordinateOperationAccuracy[] coordinateOperationAccuracy {
            get {
                return this.coordinateOperationAccuracyField;
            }
            set {
                this.coordinateOperationAccuracyField = value;
            }
        }
        
        
        public CRSPropertyType sourceCRS {
            get {
                return this.sourceCRSField;
            }
            set {
                this.sourceCRSField = value;
            }
        }
        
        
        public CRSPropertyType targetCRS {
            get {
                return this.targetCRSField;
            }
            set {
                this.targetCRSField = value;
            }
        }
    }
}
