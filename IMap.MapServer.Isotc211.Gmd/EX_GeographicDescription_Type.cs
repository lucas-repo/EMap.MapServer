namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_GeographicDescription", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public partial class EX_GeographicDescription_Type : AbstractEX_GeographicExtent_Type {
        
        private MD_Identifier_PropertyType geographicIdentifierField;
        
        
        public MD_Identifier_PropertyType geographicIdentifier {
            get {
                return this.geographicIdentifierField;
            }
            set {
                this.geographicIdentifierField = value;
            }
        }
    }
}
