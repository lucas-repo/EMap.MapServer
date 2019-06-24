namespace SharpMapServer.Ogc.Wcs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CoverageSubtypeParent", Namespace="http://www.opengis.net/wcs/2.0", IsNullable=false)]
    public partial class CoverageSubtypeParentType {
        
        private System.Xml.XmlQualifiedName coverageSubtypeField;
        
        private CoverageSubtypeParentType coverageSubtypeParentField;
        
        
        public System.Xml.XmlQualifiedName CoverageSubtype {
            get {
                return this.coverageSubtypeField;
            }
            set {
                this.coverageSubtypeField = value;
            }
        }
        
        
        public CoverageSubtypeParentType CoverageSubtypeParent {
            get {
                return this.coverageSubtypeParentField;
            }
            set {
                this.coverageSubtypeParentField = value;
            }
        }
    }
}
