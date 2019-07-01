namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("MultiPolygon", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiPolygonType : AbstractGeometricAggregateType {
        
        private PolygonPropertyType[] polygonMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("polygonMember")]
        public PolygonPropertyType[] polygonMember {
            get {
                return this.polygonMemberField;
            }
            set {
                this.polygonMemberField = value;
            }
        }
    }
}
