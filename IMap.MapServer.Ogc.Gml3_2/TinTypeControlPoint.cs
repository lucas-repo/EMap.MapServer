namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TinTypeControlPoint {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof(PointPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("pos", typeof(DirectPositionType))]
        [System.Xml.Serialization.XmlElementAttribute("posList", typeof(DirectPositionListType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
