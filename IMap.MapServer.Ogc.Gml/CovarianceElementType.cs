namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("includesElement", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CovarianceElementType {
        
        private string rowIndexField;
        
        private string columnIndexField;
        
        private double covarianceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string rowIndex {
            get {
                return this.rowIndexField;
            }
            set {
                this.rowIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string columnIndex {
            get {
                return this.columnIndexField;
            }
            set {
                this.columnIndexField = value;
            }
        }
        
        /// <remarks/>
        public double covariance {
            get {
                return this.covarianceField;
            }
            set {
                this.covarianceField = value;
            }
        }
    }
}
