namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ManifestType : BasicIdentificationType {
        
        private ReferenceGroupType[] referenceGroupField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("ReferenceGroup")]
        public ReferenceGroupType[] ReferenceGroup {
            get {
                return this.referenceGroupField;
            }
            set {
                this.referenceGroupField = value;
            }
        }
    }
}
