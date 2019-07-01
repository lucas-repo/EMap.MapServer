namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TemporalDatumType : TemporalDatumBaseType {
        
        private System.DateTime originField;
        
        
        public System.DateTime origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
    }
}
