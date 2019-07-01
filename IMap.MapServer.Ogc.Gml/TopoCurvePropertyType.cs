namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoCurveProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoCurvePropertyType {
        
        private TopoCurveType topoCurveField;
        
        /// <remarks/>
        public TopoCurveType TopoCurve {
            get {
                return this.topoCurveField;
            }
            set {
                this.topoCurveField = value;
            }
        }
    }
}
