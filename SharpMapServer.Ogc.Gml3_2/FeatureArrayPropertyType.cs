namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("featureMembers", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class FeatureArrayPropertyType {
        
        private AbstractFeatureType[] abstractFeatureField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractFeature")]
        public AbstractFeatureType[] AbstractFeature {
            get {
                return this.abstractFeatureField;
            }
            set {
                this.abstractFeatureField = value;
            }
        }
    }
}
