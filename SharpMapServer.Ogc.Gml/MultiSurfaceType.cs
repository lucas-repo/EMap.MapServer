namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiSurface", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiSurfaceType : AbstractGeometricAggregateType {
        
        private SurfacePropertyType[] surfaceMemberField;
        
        private AbstractSurfaceType[] surfaceMembersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember {
            get {
                return this.surfaceMemberField;
            }
            set {
                this.surfaceMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Surface", IsNullable=false)]
        public AbstractSurfaceType[] surfaceMembers {
            get {
                return this.surfaceMembersField;
            }
            set {
                this.surfaceMembersField = value;
            }
        }
    }
}
