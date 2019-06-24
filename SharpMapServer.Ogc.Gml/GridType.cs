namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Grid", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GridType : AbstractGeometryType {
        
        private GridLimitsType limitsField;
        
        private string[] axisNameField;
        
        private string dimensionField;
        
        /// <remarks/>
        public GridLimitsType limits {
            get {
                return this.limitsField;
            }
            set {
                this.limitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axisName")]
        public string[] axisName {
            get {
                return this.axisNameField;
            }
            set {
                this.axisNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
    }
}
