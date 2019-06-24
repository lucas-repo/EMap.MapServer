namespace SharpMapServer.SMIL20.Language {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2001/SMIL20/Language")]
    [System.Xml.Serialization.XmlRootAttribute("set", Namespace="http://www.w3.org/2001/SMIL20/", IsNullable=false)]
    public partial class setType : setPrototype {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string targetElementField;
        
        private bool skipcontentField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        public setType() {
            this.skipcontentField = true;
        }
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string targetElement {
            get {
                return this.targetElementField;
            }
            set {
                this.targetElementField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute("skip-content")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool skipcontent {
            get {
                return this.skipcontentField;
            }
            set {
                this.skipcontentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
}
