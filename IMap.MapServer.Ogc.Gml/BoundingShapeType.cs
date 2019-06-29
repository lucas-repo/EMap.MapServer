namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("boundedBy", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class BoundingShapeType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType))]
        [System.Xml.Serialization.XmlElementAttribute("Null", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
