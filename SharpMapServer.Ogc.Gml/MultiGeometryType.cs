namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiGeometry", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiGeometryType : AbstractGeometricAggregateType {
        
        private GeometryPropertyType[] geometryMemberField;
        
        private AbstractGeometryType[] geometryMembersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geometryMember")]
        public GeometryPropertyType[] geometryMember {
            get {
                return this.geometryMemberField;
            }
            set {
                this.geometryMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Geometry", IsNullable=false)]
        public AbstractGeometryType[] geometryMembers {
            get {
                return this.geometryMembersField;
            }
            set {
                this.geometryMembersField = value;
            }
        }
    }
}
