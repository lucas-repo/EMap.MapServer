namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMembers", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoPrimitiveArrayAssociationType {
        
        private AbstractTopoPrimitiveType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_TopoPrimitive")]
        public AbstractTopoPrimitiveType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
