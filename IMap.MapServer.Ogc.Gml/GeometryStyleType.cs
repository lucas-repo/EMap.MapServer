namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeometryStyle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeometryStyleType : BaseStyleDescriptorType {
        
        private object itemField;
        
        private LabelStylePropertyType labelStyleField;
        
        private string geometryPropertyField;
        
        private string geometryTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("style", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("symbol", typeof(SymbolType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public LabelStylePropertyType labelStyle {
            get {
                return this.labelStyleField;
            }
            set {
                this.labelStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string geometryProperty {
            get {
                return this.geometryPropertyField;
            }
            set {
                this.geometryPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string geometryType {
            get {
                return this.geometryTypeField;
            }
            set {
                this.geometryTypeField = value;
            }
        }
    }
}
