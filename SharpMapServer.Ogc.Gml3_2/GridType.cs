namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Grid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class GridType : AbstractGeometryType {
        
        private GridLimitsType limitsField;
        
        private string[] itemsField;
        
        private ItemsChoiceType11[] itemsElementNameField;
        
        private string dimensionField;
        
        
        public GridLimitsType limits {
            get {
                return this.limitsField;
            }
            set {
                this.limitsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("axisLabels", typeof(string), DataType="NCName")]
        [System.Xml.Serialization.XmlElementAttribute("axisName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType11[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        
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
