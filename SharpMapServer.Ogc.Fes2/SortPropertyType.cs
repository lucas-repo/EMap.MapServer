namespace SharpMapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class SortPropertyType {
        
        private string valueReferenceField;
        
        private SortOrderType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        
        public string ValueReference {
            get {
                return this.valueReferenceField;
            }
            set {
                this.valueReferenceField = value;
            }
        }
        
        
        public SortOrderType SortOrder {
            get {
                return this.sortOrderField;
            }
            set {
                this.sortOrderField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified {
            get {
                return this.sortOrderFieldSpecified;
            }
            set {
                this.sortOrderFieldSpecified = value;
            }
        }
    }
}
