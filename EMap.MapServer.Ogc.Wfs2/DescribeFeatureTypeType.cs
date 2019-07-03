namespace EMap.MapServer.Ogc.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeFeatureType", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class DescribeFeatureTypeType : BaseRequestType {
        
        private System.Xml.XmlQualifiedName[] typeNameField;
        
        private string outputFormatField;
        
        public DescribeFeatureTypeType() {
            this.outputFormatField = "application/gml+xml; version=3.2";
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("TypeName")]
        public System.Xml.XmlQualifiedName[] TypeName {
            get {
                return this.typeNameField;
            }
            set {
                this.typeNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("application/gml+xml; version=3.2")]
        public string outputFormat {
            get {
                return this.outputFormatField;
            }
            set {
                this.outputFormatField = value;
            }
        }
    }
}
