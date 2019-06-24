namespace SharpMapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSurface", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class MultiSurfaceType : AbstractGeometricAggregateType {
        
        private SurfacePropertyType[] surfaceMemberField;
        
        private SurfaceArrayPropertyType surfaceMembersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember {
            get {
                return this.surfaceMemberField;
            }
            set {
                this.surfaceMemberField = value;
            }
        }
        
        
        public SurfaceArrayPropertyType surfaceMembers {
            get {
                return this.surfaceMembersField;
            }
            set {
                this.surfaceMembersField = value;
            }
        }
    }
}
