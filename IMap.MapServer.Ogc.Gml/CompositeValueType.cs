namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueArrayType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeValue", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompositeValueType : AbstractGMLType {
        
        private ValuePropertyType[] valueComponentField;
        
        private ValueArrayPropertyType valueComponentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valueComponent")]
        public ValuePropertyType[] valueComponent {
            get {
                return this.valueComponentField;
            }
            set {
                this.valueComponentField = value;
            }
        }
        
        /// <remarks/>
        public ValueArrayPropertyType valueComponents {
            get {
                return this.valueComponentsField;
            }
            set {
                this.valueComponentsField = value;
            }
        }
    }
}
