namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Solid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SolidType : AbstractSolidType {
        
        private ShellPropertyType exteriorField;
        
        private ShellPropertyType[] interiorField;
        
        
        public ShellPropertyType exterior {
            get {
                return this.exteriorField;
            }
            set {
                this.exteriorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public ShellPropertyType[] interior {
            get {
                return this.interiorField;
            }
            set {
                this.interiorField = value;
            }
        }
    }
}
