namespace EMap.MapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoVolumeProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoVolumePropertyType {
        
        private TopoVolumeType topoVolumeField;
        
        /// <remarks/>
        public TopoVolumeType TopoVolume {
            get {
                return this.topoVolumeField;
            }
            set {
                this.topoVolumeField = value;
            }
        }
    }
}
