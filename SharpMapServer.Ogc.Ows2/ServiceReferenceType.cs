namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceReference", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class ServiceReferenceType : ReferenceType1 {
        
        private object itemField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("RequestMessage", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("RequestMessageReference", typeof(string), DataType="anyURI")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
