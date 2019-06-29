namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("priorityLocation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class PriorityLocationPropertyType : LocationPropertyType {
        
        private string priorityField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
    }
}
