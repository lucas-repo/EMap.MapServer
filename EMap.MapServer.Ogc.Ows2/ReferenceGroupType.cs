namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceGroup", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ReferenceGroupType : BasicIdentificationType {
        
        private AbstractReferenceBaseType[] abstractReferenceBaseField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractReferenceBase")]
        public AbstractReferenceBaseType[] AbstractReferenceBase {
            get {
                return this.abstractReferenceBaseField;
            }
            set {
                this.abstractReferenceBaseField = value;
            }
        }
    }
}
