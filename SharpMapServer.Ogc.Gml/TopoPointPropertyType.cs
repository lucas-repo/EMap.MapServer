namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPointProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoPointPropertyType {
        
        private TopoPointType topoPointField;
        
        /// <remarks/>
        public TopoPointType TopoPoint {
            get {
                return this.topoPointField;
            }
            set {
                this.topoPointField = value;
            }
        }
    }
}
