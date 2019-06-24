namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataChoiceTypeChoiceValue {
        
        private CategoryType categoryField;
        
        
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    }
}
