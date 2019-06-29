namespace IMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Shell", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ShellType {
        
        private SurfacePropertyType[] surfaceMemberField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember {
            get {
                return this.surfaceMemberField;
            }
            set {
                this.surfaceMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
