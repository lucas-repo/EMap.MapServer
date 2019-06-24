namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("covarianceMatrix", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CovarianceMatrixType : AbstractPositionalAccuracyType {
        
        private UnitOfMeasureType[] unitOfMeasureField;
        
        private CovarianceElementType[] includesElementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitOfMeasure")]
        public UnitOfMeasureType[] unitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesElement")]
        public CovarianceElementType[] includesElement {
            get {
                return this.includesElementField;
            }
            set {
                this.includesElementField = value;
            }
        }
    }
}
