namespace SharpMapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/wmts/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/wmts/1.0", IsNullable=false)]
    public partial class Themes {
        
        private Theme[] themeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("Theme")]
        public Theme[] Theme {
            get {
                return this.themeField;
            }
            set {
                this.themeField = value;
            }
        }
    }
}
