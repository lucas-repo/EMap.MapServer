namespace SharpMapServer.Ogc.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataRecord", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataRecordType : AbstractDataComponentType {
        
        private DataRecordTypeField[] fieldField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public DataRecordTypeField[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }
}
