namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SortBy", Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class SortByType {
        
        private SortPropertyType[] sortPropertyField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("SortProperty")]
        public SortPropertyType[] SortProperty {
            get {
                return this.sortPropertyField;
            }
            set {
                this.sortPropertyField = value;
            }
        }
    }
}
