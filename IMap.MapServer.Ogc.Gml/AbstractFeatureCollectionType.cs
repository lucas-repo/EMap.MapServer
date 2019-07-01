namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractFeatureCollectionType : AbstractFeatureType {
        
        private FeaturePropertyType[] featureMemberField;
        
        private AbstractFeatureType[] featureMembersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureMember")]
        public FeaturePropertyType[] featureMember {
            get {
                return this.featureMemberField;
            }
            set {
                this.featureMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Feature", IsNullable=false)]
        public AbstractFeatureType[] featureMembers {
            get {
                return this.featureMembersField;
            }
            set {
                this.featureMembersField = value;
            }
        }
    }
}
