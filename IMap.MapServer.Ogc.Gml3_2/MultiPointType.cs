namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPoint", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiPointType : AbstractGeometricAggregateType {
        
        private PointPropertyType[] pointMemberField;
        
        private PointArrayPropertyType pointMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("pointMember")]
        public PointPropertyType[] pointMember {
            get {
                return this.pointMemberField;
            }
            set {
                this.pointMemberField = value;
            }
        }
        
        
        public PointArrayPropertyType pointMembers {
            get {
                return this.pointMembersField;
            }
            set {
                this.pointMembersField = value;
            }
        }
    }
}
