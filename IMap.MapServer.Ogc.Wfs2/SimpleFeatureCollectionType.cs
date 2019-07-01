namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SimpleFeatureCollection", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class SimpleFeatureCollectionType {
        
        private System.Xml.XmlElement boundedByField;
        
        private MemberPropertyType[] memberField;
        
        
        public System.Xml.XmlElement boundedBy {
            get {
                return this.boundedByField;
            }
            set {
                this.boundedByField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
    }
}
