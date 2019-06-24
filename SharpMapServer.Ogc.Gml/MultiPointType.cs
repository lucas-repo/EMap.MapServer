namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPoint", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiPointType : AbstractGeometricAggregateType {
        
        private PointPropertyType[] pointMemberField;
        
        private PointType[] pointMembersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pointMember")]
        public PointPropertyType[] pointMember {
            get {
                return this.pointMemberField;
            }
            set {
                this.pointMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable=false)]
        public PointType[] pointMembers {
            get {
                return this.pointMembersField;
            }
            set {
                this.pointMembersField = value;
            }
        }
    }
}
