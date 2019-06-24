namespace SharpMapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureTypeList", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class FeatureTypeListType {
        
        private FeatureTypeType[] featureTypeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("FeatureType")]
        public FeatureTypeType[] FeatureType {
            get {
                return this.featureTypeField;
            }
            set {
                this.featureTypeField = value;
            }
        }
    }
}
