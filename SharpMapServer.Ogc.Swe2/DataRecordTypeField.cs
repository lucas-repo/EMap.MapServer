namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataRecordTypeField : AbstractDataComponentPropertyType {
        
        private string nameField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
