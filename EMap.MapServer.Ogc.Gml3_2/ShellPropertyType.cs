namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ShellPropertyType {
        
        private ShellType shellField;
        
        
        public ShellType Shell {
            get {
                return this.shellField;
            }
            set {
                this.shellField = value;
            }
        }
    }
}
