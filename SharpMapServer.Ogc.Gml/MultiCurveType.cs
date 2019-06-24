namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiCurve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiCurveType : AbstractGeometricAggregateType {
        
        private CurvePropertyType[] curveMemberField;
        
        private AbstractCurveType[] curveMembersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember {
            get {
                return this.curveMemberField;
            }
            set {
                this.curveMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Curve", IsNullable=false)]
        public AbstractCurveType[] curveMembers {
            get {
                return this.curveMembersField;
            }
            set {
                this.curveMembersField = value;
            }
        }
    }
}
