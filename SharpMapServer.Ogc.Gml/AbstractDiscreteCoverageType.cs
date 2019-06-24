namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveCoverageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointCoverageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractDiscreteCoverageType : AbstractCoverageType {
        
        private CoverageFunctionType coverageFunctionField;
        
        /// <remarks/>
        public CoverageFunctionType coverageFunction {
            get {
                return this.coverageFunctionField;
            }
            set {
                this.coverageFunctionField = value;
            }
        }
    }
}
