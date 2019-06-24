namespace SharpMapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalParameters", Namespace="http://www.opengis.net/ows/2.0", IsNullable=false)]
    public partial class AdditionalParametersType : AdditionalParametersBaseType {
        
        private AdditionalParameter[] additionalParameterField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalParameter")]
        public AdditionalParameter[] AdditionalParameter {
            get {
                return this.additionalParameterField;
            }
            set {
                this.additionalParameterField = value;
            }
        }
    }
}
