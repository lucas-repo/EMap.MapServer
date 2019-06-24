namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class additionalObjects {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof(FeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleFeatureCollection", typeof(SimpleFeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueCollection", typeof(ValueCollectionType))]
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
