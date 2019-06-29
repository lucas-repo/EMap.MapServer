namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractGeneralDerivedCRSType : AbstractCRSType {
        
        private GeneralConversionPropertyType conversionField;
        
        
        public GeneralConversionPropertyType conversion {
            get {
                return this.conversionField;
            }
            set {
                this.conversionField = value;
            }
        }
    }
}
