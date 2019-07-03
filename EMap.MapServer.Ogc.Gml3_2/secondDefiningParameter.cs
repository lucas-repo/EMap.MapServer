namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SecondDefiningParameter {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("inverseFlattening", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("isSphere", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("semiMinorAxis", typeof(LengthType))]
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
