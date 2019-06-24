namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("DynamicFeatureCollection", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DynamicFeatureCollectionType : DynamicFeatureType {
        
        private DynamicFeatureMemberType dynamicMembersField;
        
        
        public DynamicFeatureMemberType dynamicMembers {
            get {
                return this.dynamicMembersField;
            }
            set {
                this.dynamicMembersField = value;
            }
        }
    }
}
