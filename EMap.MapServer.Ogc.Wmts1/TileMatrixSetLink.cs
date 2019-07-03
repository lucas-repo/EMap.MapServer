namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class TileMatrixSetLink {
        
        private string tileMatrixSetField;
        
        private TileMatrixLimits[] tileMatrixSetLimitsField;
        
        
        public string TileMatrixSet {
            get {
                return this.tileMatrixSetField;
            }
            set {
                this.tileMatrixSetField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("TileMatrixLimits", IsNullable=false)]
        public TileMatrixLimits[] TileMatrixSetLimits {
            get {
                return this.tileMatrixSetLimitsField;
            }
            set {
                this.tileMatrixSetLimitsField = value;
            }
        }
    }
}
