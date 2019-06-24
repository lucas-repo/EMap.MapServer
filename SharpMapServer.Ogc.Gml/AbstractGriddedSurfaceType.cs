namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType {
        
        private AbstractGriddedSurfaceTypeRow[] rowField;
        
        private string rowsField;
        
        private string columnsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public AbstractGriddedSurfaceTypeRow[] row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string rows {
            get {
                return this.rowsField;
            }
            set {
                this.rowsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
            }
        }
    }
}
