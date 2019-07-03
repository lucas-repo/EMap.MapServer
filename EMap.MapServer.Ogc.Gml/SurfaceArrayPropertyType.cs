namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("surfaceArrayProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SurfaceArrayPropertyType {
        
        private AbstractSurfaceType[] _SurfaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Surface")]
        public AbstractSurfaceType[] _Surface {
            get {
                return this._SurfaceField;
            }
            set {
                this._SurfaceField = value;
            }
        }
    }
}
