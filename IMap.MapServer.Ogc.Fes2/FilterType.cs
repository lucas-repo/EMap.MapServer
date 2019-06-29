namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Filter", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class FilterType : AbstractSelectionClauseType {
        
        private ComparisonOpsType comparisonOpsField;
        
        private SpatialOpsType spatialOpsField;
        
        private TemporalOpsType temporalOpsField;
        
        private LogicOpsType logicOpsField;
        
        private ExtensionOpsType extensionOpsField;
        
        private FunctionType functionField;
        
        private AbstractIdType[] _IdField;
        
        
        public ComparisonOpsType comparisonOps {
            get {
                return this.comparisonOpsField;
            }
            set {
                this.comparisonOpsField = value;
            }
        }
        
        
        public SpatialOpsType spatialOps {
            get {
                return this.spatialOpsField;
            }
            set {
                this.spatialOpsField = value;
            }
        }
        
        
        public TemporalOpsType temporalOps {
            get {
                return this.temporalOpsField;
            }
            set {
                this.temporalOpsField = value;
            }
        }
        
        
        public LogicOpsType logicOps {
            get {
                return this.logicOpsField;
            }
            set {
                this.logicOpsField = value;
            }
        }
        
        
        public ExtensionOpsType extensionOps {
            get {
                return this.extensionOpsField;
            }
            set {
                this.extensionOpsField = value;
            }
        }
        
        
        public FunctionType Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("_Id")]
        public AbstractIdType[] _Id {
            get {
                return this._IdField;
            }
            set {
                this._IdField = value;
            }
        }
    }
}
