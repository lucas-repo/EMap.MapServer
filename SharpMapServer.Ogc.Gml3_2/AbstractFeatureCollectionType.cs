namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureCollectionType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractFeatureCollectionType : AbstractFeatureType {
        
        private FeaturePropertyType[] featureMemberField;
        
        private FeatureArrayPropertyType featureMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("featureMember")]
        public FeaturePropertyType[] featureMember {
            get {
                return this.featureMemberField;
            }
            set {
                this.featureMemberField = value;
            }
        }
        
        
        public FeatureArrayPropertyType featureMembers {
            get {
                return this.featureMembersField;
            }
            set {
                this.featureMembersField = value;
            }
        }
    }
}
