namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CovarianceMatrixType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativeInternalPositionalAccuracyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbsoluteExternalPositionalAccuracyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractPositionalAccuracyType {
        
        private CodeType1 measureDescriptionField;
        
        /// <remarks/>
        public CodeType1 measureDescription {
            get {
                return this.measureDescriptionField;
            }
            set {
                this.measureDescriptionField = value;
            }
        }
    }
}
