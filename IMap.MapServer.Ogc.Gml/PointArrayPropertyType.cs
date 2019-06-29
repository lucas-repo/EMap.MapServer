namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("pointArrayProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class PointArrayPropertyType {
        
        private PointType[] pointField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Point")]
        public PointType[] Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
            }
        }
    }
}
