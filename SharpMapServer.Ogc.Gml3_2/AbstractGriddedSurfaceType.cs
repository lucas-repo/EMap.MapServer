namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType {
        
        private AbstractGriddedSurfaceTypeRow[] rowsField;
        
        private string rows1Field;
        
        private string columnsField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Row", IsNullable=false)]
        public AbstractGriddedSurfaceTypeRow[] rows {
            get {
                return this.rowsField;
            }
            set {
                this.rowsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute("rows", DataType="integer")]
        public string rows1 {
            get {
                return this.rows1Field;
            }
            set {
                this.rows1Field = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
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
