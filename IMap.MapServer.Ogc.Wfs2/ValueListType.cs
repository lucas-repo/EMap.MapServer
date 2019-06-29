namespace IMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ValueList", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class ValueListType {
        
        private object[] valueField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public object[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
