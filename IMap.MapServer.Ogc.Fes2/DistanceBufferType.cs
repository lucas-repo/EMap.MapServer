namespace IMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class DistanceBufferType : SpatialOpsType {
        
        private object[] itemsField;
        
        private MeasureType distanceField;
        
        
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
        
        
        public MeasureType Distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
    }
}
