namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopologyStyle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopologyStyleType : BaseStyleDescriptorType {
        
        private object itemField;
        
        private LabelStylePropertyType labelStyleField;
        
        private string topologyPropertyField;
        
        private string topologyTypeField;
        
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
        public string topologyProperty {
            get {
                return this.topologyPropertyField;
            }
            set {
                this.topologyPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string topologyType {
            get {
                return this.topologyTypeField;
            }
            set {
                this.topologyTypeField = value;
            }
        }
    }
}
