namespace EMap.MapServer.Ogc.Gmlcov {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ExtensionType", Namespace="http://www.opengis.net/gmlcov/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Extension", Namespace="http://www.opengis.net/gmlcov/1.0", IsNullable=false)]
    public partial class ExtensionType1 {
        
        private System.Xml.XmlElement[] anyField;
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
}
