namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiCurve", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiCurveType : AbstractGeometricAggregateType {
        
        private CurvePropertyType[] curveMemberField;
        
        private CurveArrayPropertyType curveMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember {
            get {
                return this.curveMemberField;
            }
            set {
                this.curveMemberField = value;
            }
        }
        
        
        public CurveArrayPropertyType curveMembers {
            get {
                return this.curveMembersField;
            }
            set {
                this.curveMembersField = value;
            }
        }
    }
}
