namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiGeometry", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiGeometryType : AbstractGeometricAggregateType {
        
        private GeometryPropertyType[] geometryMemberField;
        
        private GeometryArrayPropertyType geometryMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("geometryMember")]
        public GeometryPropertyType[] geometryMember {
            get {
                return this.geometryMemberField;
            }
            set {
                this.geometryMemberField = value;
            }
        }
        
        
        public GeometryArrayPropertyType geometryMembers {
            get {
                return this.geometryMembersField;
            }
            set {
                this.geometryMembersField = value;
            }
        }
    }
}
