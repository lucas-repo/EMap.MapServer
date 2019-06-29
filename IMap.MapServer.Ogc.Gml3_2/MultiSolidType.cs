namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSolid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiSolidType : AbstractGeometricAggregateType {
        
        private SolidPropertyType[] solidMemberField;
        
        private SolidArrayPropertyType solidMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("solidMember")]
        public SolidPropertyType[] solidMember {
            get {
                return this.solidMemberField;
            }
            set {
                this.solidMemberField = value;
            }
        }
        
        
        public SolidArrayPropertyType solidMembers {
            get {
                return this.solidMembersField;
            }
            set {
                this.solidMembersField = value;
            }
        }
    }
}
