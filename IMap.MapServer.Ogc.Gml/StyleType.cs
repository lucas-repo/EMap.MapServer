namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Style", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class StyleType : AbstractStyleType {
        
        private FeatureStylePropertyType[] featureStyleField;
        
        private GraphStylePropertyType graphStyleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureStyle")]
        public FeatureStylePropertyType[] featureStyle {
            get {
                return this.featureStyleField;
            }
            set {
                this.featureStyleField = value;
            }
        }
        
        /// <remarks/>
        public GraphStylePropertyType graphStyle {
            get {
                return this.graphStyleField;
            }
            set {
                this.graphStyleField = value;
            }
        }
    }
}
