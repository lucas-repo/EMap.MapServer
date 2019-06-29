namespace IMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataArrayTypeEncoding {
        
        private AbstractEncodingType abstractEncodingField;
        
        
        public AbstractEncodingType AbstractEncoding {
            get {
                return this.abstractEncodingField;
            }
            set {
                this.abstractEncodingField = value;
            }
        }
    }
}
