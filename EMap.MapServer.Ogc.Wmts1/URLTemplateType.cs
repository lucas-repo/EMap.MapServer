namespace EMap.MapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wmts/1.0")]
    public partial class URLTemplateType {
        
        private string formatField;
        
        private string resourceTypeField;
        
        private string templateField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resourceType {
            get {
                return this.resourceTypeField;
            }
            set {
                this.resourceTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
            }
        }
    }
}
