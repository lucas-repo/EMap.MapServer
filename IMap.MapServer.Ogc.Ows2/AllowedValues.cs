namespace IMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class AllowedValues {
        
        private object[] itemsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Range", typeof(RangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(ValueType))]
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
