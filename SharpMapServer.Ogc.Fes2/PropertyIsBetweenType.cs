namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class PropertyIsBetweenType : ComparisonOpsType {
        
        private object expressionField;
        
        private LowerBoundaryType lowerBoundaryField;
        
        private UpperBoundaryType upperBoundaryField;
        
        
        public object expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        
        public LowerBoundaryType LowerBoundary {
            get {
                return this.lowerBoundaryField;
            }
            set {
                this.lowerBoundaryField = value;
            }
        }
        
        
        public UpperBoundaryType UpperBoundary {
            get {
                return this.upperBoundaryField;
            }
            set {
                this.upperBoundaryField = value;
            }
        }
    }
}
