namespace IMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Bag", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class BagType : AbstractGMLType {
        
        private AssociationRoleType[] memberField;
        
        private ArrayAssociationType membersField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public AssociationRoleType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        
        public ArrayAssociationType members {
            get {
                return this.membersField;
            }
            set {
                this.membersField = value;
            }
        }
    }
}
