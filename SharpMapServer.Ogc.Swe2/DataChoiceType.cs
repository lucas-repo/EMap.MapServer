namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataChoice", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataChoiceType : AbstractDataComponentType {
        
        private DataChoiceTypeChoiceValue choiceValueField;
        
        private DataChoiceTypeItem[] itemField;
        
        
        public DataChoiceTypeChoiceValue choiceValue {
            get {
                return this.choiceValueField;
            }
            set {
                this.choiceValueField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public DataChoiceTypeItem[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
