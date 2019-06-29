namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_SpatialRepresentation_PropertyType {
        
        private AbstractMD_SpatialRepresentation_Type abstractMD_SpatialRepresentationField;
        
        private string uuidrefField;
        
        private string nilReasonField;
        
        
        public AbstractMD_SpatialRepresentation_Type AbstractMD_SpatialRepresentation {
            get {
                return this.abstractMD_SpatialRepresentationField;
            }
            set {
                this.abstractMD_SpatialRepresentationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uuidref {
            get {
                return this.uuidrefField;
            }
            set {
                this.uuidrefField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.isotc211.org/2005/gco")]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
