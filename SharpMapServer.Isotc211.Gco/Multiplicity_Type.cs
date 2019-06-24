namespace SharpMapServer.Isotc211.Gco {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("Multiplicity", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
    public partial class Multiplicity_Type : AbstractObject_Type {
        
        private MultiplicityRange_PropertyType[] rangeField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("range")]
        public MultiplicityRange_PropertyType[] range {
            get {
                return this.rangeField;
            }
            set {
                this.rangeField = value;
            }
        }
    }
}
