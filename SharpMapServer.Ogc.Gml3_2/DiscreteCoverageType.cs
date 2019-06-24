namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPointCoverage", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DiscreteCoverageType : AbstractCoverageType {
        
        private CoverageFunctionType coverageFunctionField;
        
        
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
