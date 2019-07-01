namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("rangeSet", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class RangeSetType {
        
        private object[] itemsField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractScalarValueList", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DataBlock", typeof(DataBlockType))]
        [System.Xml.Serialization.XmlElementAttribute("File", typeof(FileType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueArray", typeof(ValueArrayType))]
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
