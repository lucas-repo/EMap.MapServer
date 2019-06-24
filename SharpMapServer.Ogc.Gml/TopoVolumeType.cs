namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoVolume", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoVolumeType : AbstractTopologyType {
        
        private DirectedTopoSolidPropertyType[] directedTopoSolidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
        public DirectedTopoSolidPropertyType[] directedTopoSolid {
            get {
                return this.directedTopoSolidField;
            }
            set {
                this.directedTopoSolidField = value;
            }
        }
    }
}
