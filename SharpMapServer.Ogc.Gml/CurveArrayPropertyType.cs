namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("curveArrayProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CurveArrayPropertyType {
        
        private AbstractCurveType[] _CurveField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Curve")]
        public AbstractCurveType[] _Curve {
            get {
                return this._CurveField;
            }
            set {
                this._CurveField = value;
            }
        }
    }
}
