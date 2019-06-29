namespace IMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrixSetLimits {
        
        private TileMatrixLimits[] tileMatrixLimitsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("TileMatrixLimits")]
        public TileMatrixLimits[] TileMatrixLimits {
            get {
                return this.tileMatrixLimitsField;
            }
            set {
                this.tileMatrixLimitsField = value;
            }
        }
    }
}
