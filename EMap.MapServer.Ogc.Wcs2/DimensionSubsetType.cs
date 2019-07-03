namespace EMap.MapServer.Ogc.Wcs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DimensionSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DimensionTrimType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wcs/2.0")]
    public abstract partial class DimensionSubsetType {
        
        private string dimensionField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="NCName")]
        public string Dimension {
            get {
                return this.dimensionField;
            }
            set {
                this.dimensionField = value;
            }
        }
    }
}
