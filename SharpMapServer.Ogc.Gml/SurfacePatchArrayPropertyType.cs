namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrianglePatchArrayPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonPatchArrayPropertyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("patches", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SurfacePatchArrayPropertyType {
        
        private AbstractSurfacePatchType[] _SurfacePatchField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_SurfacePatch")]
        public AbstractSurfacePatchType[] _SurfacePatch {
            get {
                return this._SurfacePatchField;
            }
            set {
                this._SurfacePatchField = value;
            }
        }
    }
}
