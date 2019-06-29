namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationParameterType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractGeneralOperationParameterType : IdentifiedObjectType {
        
        private string minimumOccursField;
        
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string minimumOccurs {
            get {
                return this.minimumOccursField;
            }
            set {
                this.minimumOccursField = value;
            }
        }
    }
}
