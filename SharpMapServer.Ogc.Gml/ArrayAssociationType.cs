namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("members", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ArrayAssociationType {
        
        private object[] _ObjectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Object")]
        public object[] _Object {
            get {
                return this._ObjectField;
            }
            set {
                this._ObjectField = value;
            }
        }
    }
}
