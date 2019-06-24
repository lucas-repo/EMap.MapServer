namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndexMapType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GridFunction", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GridFunctionType {
        
        private SequenceRuleType sequenceRuleField;
        
        private string startPointField;
        
        /// <remarks/>
        public SequenceRuleType sequenceRule {
            get {
                return this.sequenceRuleField;
            }
            set {
                this.sequenceRuleField = value;
            }
        }
        
        /// <remarks/>
        public string startPoint {
            get {
                return this.startPointField;
            }
            set {
                this.startPointField = value;
            }
        }
    }
}
