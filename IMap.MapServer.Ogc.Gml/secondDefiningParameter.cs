namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SecondDefiningParameter {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inverseFlattening", typeof(MeasureType))]
        [System.Xml.Serialization.XmlElementAttribute("isSphere", typeof(SecondDefiningParameterIsSphere))]
        [System.Xml.Serialization.XmlElementAttribute("semiMinorAxis", typeof(LengthType))]
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
