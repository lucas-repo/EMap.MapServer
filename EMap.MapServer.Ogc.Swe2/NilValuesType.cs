namespace EMap.MapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NilValues", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class NilValuesType : AbstractSWEType {
        
        private NilValue[] nilValueField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("nilValue")]
        public NilValue[] nilValue {
            get {
                return this.nilValueField;
            }
            set {
                this.nilValueField = value;
            }
        }
    }
}
