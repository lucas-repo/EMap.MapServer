namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Tuple", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class TupleType {
        
        private MemberPropertyType[] memberField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public MemberPropertyType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
    }
}
