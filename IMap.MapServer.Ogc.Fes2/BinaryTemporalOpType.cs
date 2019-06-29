namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("After", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class BinaryTemporalOpType : TemporalOpsType {
        
        private object[] itemsField;
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
