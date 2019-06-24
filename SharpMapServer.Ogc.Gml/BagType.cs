namespace SharpMapServer.Ogc.Gml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WindowsFormsApp1", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Bag", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class BagType : AbstractGMLType {
        
        private AssociationType[] memberField;
        
        private object[] membersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public AssociationType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_Object", IsNullable=false)]
        public object[] members {
            get {
                return this.membersField;
            }
            set {
                this.membersField = value;
            }
        }
    }
}
