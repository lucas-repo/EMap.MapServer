namespace SharpMapServer.SMIL20 {
    
    
    
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(setType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2001/SMIL20/")]
    public partial class setPrototype {
        
        private string attributeNameField;
        
        private animatePrototypeAttributeType attributeTypeField;
        
        private string toField;
        
        public setPrototype() {
            this.attributeTypeField = animatePrototypeAttributeType.auto;
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeName {
            get {
                return this.attributeNameField;
            }
            set {
                this.attributeNameField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(animatePrototypeAttributeType.auto)]
        public animatePrototypeAttributeType attributeType {
            get {
                return this.attributeTypeField;
            }
            set {
                this.attributeTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
}
